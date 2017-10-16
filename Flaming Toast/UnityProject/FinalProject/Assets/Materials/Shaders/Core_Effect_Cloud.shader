// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:False,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0,fgcg:0,fgcb:0,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True,fsmp:False;n:type:ShaderForge.SFN_Final,id:4795,x:33706,y:32612,varname:node_4795,prsc:2|emission-7218-OUT;n:type:ShaderForge.SFN_Tex2d,id:6673,x:33169,y:32672,varname:node_6673,prsc:2,tex:19e25565a8eca5c43b66ad20e80cb41b,ntxv:0,isnm:False|TEX-5049-TEX;n:type:ShaderForge.SFN_Color,id:1309,x:33169,y:32529,ptovrint:False,ptlb:Colour,ptin:_Colour,varname:node_1309,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:2652,x:33169,y:32944,ptovrint:False,ptlb:Brightness,ptin:_Brightness,varname:node_2652,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Clamp01,id:7218,x:33526,y:32712,varname:node_7218,prsc:2|IN-758-OUT;n:type:ShaderForge.SFN_Multiply,id:758,x:33360,y:32711,varname:node_758,prsc:2|A-1309-RGB,B-6673-R,C-1334-A,D-2652-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:5049,x:32998,y:32672,ptovrint:False,ptlb:Texture,ptin:_Texture,varname:node_5049,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:19e25565a8eca5c43b66ad20e80cb41b,ntxv:0,isnm:False;n:type:ShaderForge.SFN_VertexColor,id:1334,x:33169,y:32791,varname:node_1334,prsc:2;proporder:5049-1309-2652;pass:END;sub:END;*/

Shader "Shader Forge/Core_Effect_Cloud" {
    Properties {
        _Texture ("Texture", 2D) = "white" {}
        _Colour ("Colour", Color) = (1,0,0,1)
        _Brightness ("Brightness", Float ) = 1
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _Colour;
            uniform float _Brightness;
            uniform sampler2D _Texture; uniform float4 _Texture_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 node_6673 = tex2D(_Texture,TRANSFORM_TEX(i.uv0, _Texture));
                float3 emissive = saturate((_Colour.rgb*node_6673.r*i.vertexColor.a*_Brightness));
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
