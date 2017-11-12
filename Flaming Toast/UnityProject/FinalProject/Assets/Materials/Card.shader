// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33027,y:32700,varname:node_3138,prsc:2|emission-5545-OUT,alpha-2497-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:32197,y:32516,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.7279412,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Tex2d,id:6297,x:31946,y:32960,varname:node_6297,prsc:2,tex:3d15f693d99e62c439a563b356b6e775,ntxv:0,isnm:False|UVIN-5683-OUT,TEX-9698-TEX;n:type:ShaderForge.SFN_Tex2d,id:1367,x:32311,y:32807,varname:_node_6297_copy,prsc:2,tex:3d15f693d99e62c439a563b356b6e775,ntxv:0,isnm:False|UVIN-5683-OUT,TEX-9698-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:9698,x:31647,y:32877,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_9698,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3d15f693d99e62c439a563b356b6e775,ntxv:0,isnm:False;n:type:ShaderForge.SFN_TexCoord,id:6009,x:30125,y:32666,varname:node_6009,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:5545,x:32506,y:32807,varname:node_5545,prsc:2|A-7241-RGB,B-1367-R,C-2578-OUT;n:type:ShaderForge.SFN_Multiply,id:4381,x:32162,y:33066,varname:node_4381,prsc:2|A-6297-A,B-9035-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9035,x:31946,y:33111,ptovrint:False,ptlb:Transparency,ptin:_Transparency,varname:node_9035,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Tex2d,id:6411,x:30969,y:32153,ptovrint:False,ptlb:Texture(distortion),ptin:_Texturedistortion,varname:node_6411,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:eef400bbc5065d24d9b7ed2579bf7fb8,ntxv:0,isnm:False|UVIN-8249-UVOUT;n:type:ShaderForge.SFN_Multiply,id:5422,x:31204,y:32250,varname:node_5422,prsc:2|A-6009-U,B-6411-R,C-5390-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5390,x:30969,y:32342,ptovrint:False,ptlb:Distortion amount,ptin:_Distortionamount,varname:node_5390,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Append,id:5683,x:31633,y:32453,cmnt:distortion output,varname:node_5683,prsc:2|A-920-OUT,B-6009-V;n:type:ShaderForge.SFN_Blend,id:920,x:31400,y:32382,varname:node_920,prsc:2,blmd:6,clmp:False|SRC-5422-OUT,DST-6009-U;n:type:ShaderForge.SFN_Panner,id:8249,x:30793,y:32153,varname:node_8249,prsc:2,spu:0,spv:0.1|UVIN-8895-OUT;n:type:ShaderForge.SFN_Multiply,id:1150,x:32162,y:33203,varname:node_1150,prsc:2|A-6349-R,B-2731-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2731,x:31846,y:33281,ptovrint:False,ptlb:Line Transparency,ptin:_LineTransparency,varname:node_2731,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Tex2d,id:6349,x:30900,y:32978,ptovrint:False,ptlb:Texture(mask),ptin:_Texturemask,varname:node_6349,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:854efec3a0dbc89439c19aef9bc88dda,ntxv:0,isnm:False|UVIN-159-OUT;n:type:ShaderForge.SFN_Multiply,id:159,x:30462,y:32815,varname:node_159,prsc:2|A-6009-UVOUT,B-2119-OUT;n:type:ShaderForge.SFN_Blend,id:2497,x:32456,y:33128,cmnt:line blending,varname:node_2497,prsc:2,blmd:19,clmp:True|SRC-1150-OUT,DST-4381-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2578,x:32311,y:32962,ptovrint:False,ptlb:Brightness,ptin:_Brightness,varname:node_2578,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_ValueProperty,id:4227,x:30176,y:32447,ptovrint:False,ptlb:Distortion Scale,ptin:_DistortionScale,varname:node_4227,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:8895,x:30390,y:32447,varname:node_8895,prsc:2|A-4227-OUT,B-6009-UVOUT;n:type:ShaderForge.SFN_ValueProperty,id:2119,x:30254,y:32962,ptovrint:False,ptlb:Line Amount,ptin:_LineAmount,varname:node_2119,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:50;proporder:7241-9698-9035-6411-5390-2731-6349-2578-4227-2119;pass:END;sub:END;*/

Shader "Shader Forge/Card" {
    Properties {
        _Color ("Color", Color) = (0.7279412,0,0,1)
        _MainTex ("MainTex", 2D) = "white" {}
        _Transparency ("Transparency", Float ) = 1
        _Texturedistortion ("Texture(distortion)", 2D) = "white" {}
        _Distortionamount ("Distortion amount", Float ) = 0.1
        _LineTransparency ("Line Transparency", Float ) = 0.1
        _Texturemask ("Texture(mask)", 2D) = "white" {}
        _Brightness ("Brightness", Float ) = 2
        _DistortionScale ("Distortion Scale", Float ) = 1
        _LineAmount ("Line Amount", Float ) = 50
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
            Blend SrcAlpha OneMinusSrcAlpha
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _Color;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float _Transparency;
            uniform sampler2D _Texturedistortion; uniform float4 _Texturedistortion_ST;
            uniform float _Distortionamount;
            uniform float _LineTransparency;
            uniform sampler2D _Texturemask; uniform float4 _Texturemask_ST;
            uniform float _Brightness;
            uniform float _DistortionScale;
            uniform float _LineAmount;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float4 node_838 = _Time;
                float2 node_8249 = ((_DistortionScale*i.uv0)+node_838.g*float2(0,0.1));
                float4 _Texturedistortion_var = tex2D(_Texturedistortion,TRANSFORM_TEX(node_8249, _Texturedistortion));
                float node_5422 = (i.uv0.r*_Texturedistortion_var.r*_Distortionamount);
                float2 node_5683 = float2((1.0-(1.0-node_5422)*(1.0-i.uv0.r)),i.uv0.g); // distortion output
                float4 _node_6297_copy = tex2D(_MainTex,TRANSFORM_TEX(node_5683, _MainTex));
                float3 emissive = (_Color.rgb*_node_6297_copy.r*_Brightness);
                float3 finalColor = emissive;
                float2 node_159 = (i.uv0*_LineAmount);
                float4 _Texturemask_var = tex2D(_Texturemask,TRANSFORM_TEX(node_159, _Texturemask));
                float node_1150 = (_Texturemask_var.r*_LineTransparency);
                float4 node_6297 = tex2D(_MainTex,TRANSFORM_TEX(node_5683, _MainTex));
                return fixed4(finalColor,saturate(((node_6297.a*_Transparency)-node_1150)));
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
