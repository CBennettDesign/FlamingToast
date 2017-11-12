// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:1,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:32967,y:32691,varname:node_3138,prsc:2|emission-5938-OUT,alpha-7423-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:3248,x:32014,y:32947,ptovrint:False,ptlb:texture,ptin:_texture,varname:node_3248,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:882e87f56ceffd14f946443e2352b814,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:1329,x:32198,y:32875,varname:node_1329,prsc:2,tex:882e87f56ceffd14f946443e2352b814,ntxv:0,isnm:False|UVIN-6831-UVOUT,TEX-3248-TEX;n:type:ShaderForge.SFN_Tex2d,id:8357,x:31785,y:32651,varname:node_8357,prsc:2,tex:882e87f56ceffd14f946443e2352b814,ntxv:0,isnm:False|TEX-3248-TEX;n:type:ShaderForge.SFN_TexCoord,id:8193,x:31592,y:32387,varname:node_8193,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Parallax,id:6831,x:31860,y:32457,varname:node_6831,prsc:2|UVIN-8193-UVOUT,HEI-8357-A,DEP-3860-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3860,x:31592,y:32550,ptovrint:False,ptlb:depth,ptin:_depth,varname:node_3860,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.07;n:type:ShaderForge.SFN_Multiply,id:5938,x:32472,y:32825,varname:node_5938,prsc:2|A-6230-OUT,B-1329-RGB;n:type:ShaderForge.SFN_ValueProperty,id:6230,x:32213,y:32736,ptovrint:False,ptlb:Brightness,ptin:_Brightness,varname:node_6230,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:9111,x:32485,y:33003,varname:node_9111,prsc:2|A-1329-A,B-3318-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3318,x:32211,y:33075,ptovrint:False,ptlb:opacity amount,ptin:_opacityamount,varname:node_3318,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Clamp01,id:7423,x:32717,y:33003,varname:node_7423,prsc:2|IN-9111-OUT;proporder:3248-3860-6230-3318;pass:END;sub:END;*/

Shader "Shader Forge/Background_Nebula" {
    Properties {
        _texture ("texture", 2D) = "white" {}
        _depth ("depth", Float ) = 0.07
        _Brightness ("Brightness", Float ) = 1
        _opacityamount ("opacity amount", Float ) = 1
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
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
            Blend One OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _texture; uniform float4 _texture_ST;
            uniform float _depth;
            uniform float _Brightness;
            uniform float _opacityamount;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
////// Lighting:
////// Emissive:
                float4 node_8357 = tex2D(_texture,TRANSFORM_TEX(i.uv0, _texture));
                float2 node_6831 = (_depth*(node_8357.a - 0.5)*mul(tangentTransform, viewDirection).xy + i.uv0);
                float4 node_1329 = tex2D(_texture,TRANSFORM_TEX(node_6831.rg, _texture));
                float3 emissive = (_Brightness*node_1329.rgb);
                float3 finalColor = emissive;
                float node_9111 = (node_1329.a*_opacityamount);
                return fixed4(finalColor,saturate(node_9111));
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
