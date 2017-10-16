// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:False,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33328,y:32642,varname:node_3138,prsc:2|diff-5246-OUT,spec-5246-OUT,gloss-5246-OUT,emission-4516-OUT,alpha-2480-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:31919,y:32533,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.07843138,c2:0.3921569,c3:0.7843137,c4:1;n:type:ShaderForge.SFN_Tex2d,id:8198,x:31765,y:32650,varname:node_8198,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-5981-UVOUT,TEX-2319-TEX;n:type:ShaderForge.SFN_TexCoord,id:5810,x:30652,y:32717,varname:node_5810,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:5981,x:31551,y:32650,varname:node_5981,prsc:2,spu:-0.1,spv:-0.6|UVIN-4379-UVOUT;n:type:ShaderForge.SFN_Rotator,id:4379,x:31372,y:32650,varname:node_4379,prsc:2|UVIN-5962-OUT,PIV-981-OUT,SPD-3882-OUT;n:type:ShaderForge.SFN_Rotator,id:3504,x:31372,y:32800,varname:node_3504,prsc:2|UVIN-5962-OUT,PIV-981-OUT,SPD-4076-OUT;n:type:ShaderForge.SFN_Panner,id:6244,x:31551,y:32800,varname:node_6244,prsc:2,spu:0.5,spv:0.1|UVIN-3504-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:7063,x:31765,y:32800,varname:_node_8198_copy,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-6244-UVOUT,TEX-2319-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:2319,x:31581,y:33071,ptovrint:False,ptlb:node_2319,ptin:_node_2319,varname:node_2319,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Vector1,id:3882,x:31146,y:32660,varname:node_3882,prsc:2,v1:-1;n:type:ShaderForge.SFN_Vector1,id:4076,x:31146,y:32897,varname:node_4076,prsc:2,v1:0.3;n:type:ShaderForge.SFN_Blend,id:2283,x:32011,y:32768,varname:node_2283,prsc:2,blmd:17,clmp:True|SRC-8198-R,DST-7063-R;n:type:ShaderForge.SFN_OneMinus,id:3416,x:32197,y:33015,varname:node_3416,prsc:2|IN-2283-OUT;n:type:ShaderForge.SFN_Multiply,id:5962,x:30985,y:32764,varname:node_5962,prsc:2|A-5810-UVOUT,B-6031-OUT;n:type:ShaderForge.SFN_Vector1,id:6031,x:30770,y:32895,varname:node_6031,prsc:2,v1:3;n:type:ShaderForge.SFN_Blend,id:3714,x:32503,y:32734,varname:node_3714,prsc:2,blmd:2,clmp:True|SRC-1945-OUT,DST-3416-OUT;n:type:ShaderForge.SFN_RemapRange,id:7488,x:32379,y:33017,varname:node_7488,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-3416-OUT;n:type:ShaderForge.SFN_Clamp01,id:2480,x:32551,y:33017,varname:node_2480,prsc:2|IN-7488-OUT;n:type:ShaderForge.SFN_Vector1,id:5246,x:33093,y:32597,varname:node_5246,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:1118,x:32718,y:32800,varname:node_1118,prsc:2|A-3714-OUT,B-5383-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5383,x:32513,y:32922,ptovrint:False,ptlb:Brightness,ptin:_Brightness,varname:node_5383,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Fresnel,id:1805,x:31685,y:32291,varname:node_1805,prsc:2|EXP-9693-OUT;n:type:ShaderForge.SFN_Vector1,id:9693,x:31462,y:32274,varname:node_9693,prsc:2,v1:3;n:type:ShaderForge.SFN_Multiply,id:5631,x:31905,y:32332,varname:node_5631,prsc:2|A-9813-OUT,B-1805-OUT;n:type:ShaderForge.SFN_Vector1,id:9813,x:31756,y:32199,varname:node_9813,prsc:2,v1:2;n:type:ShaderForge.SFN_Min,id:4516,x:33111,y:32806,varname:node_4516,prsc:2|A-1118-OUT,B-2318-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2318,x:32898,y:32876,ptovrint:False,ptlb:Max Brightness,ptin:_MaxBrightness,varname:node_2318,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:172,x:32132,y:32428,varname:node_172,prsc:2|A-5631-OUT,B-7241-RGB;n:type:ShaderForge.SFN_Add,id:1945,x:32318,y:32699,varname:node_1945,prsc:2|A-172-OUT,B-7241-RGB;n:type:ShaderForge.SFN_Append,id:981,x:30943,y:32528,varname:node_981,prsc:2|A-4200-OUT,B-7630-OUT;n:type:ShaderForge.SFN_Slider,id:4200,x:30515,y:32471,ptovrint:False,ptlb:Rotation U,ptin:_RotationU,varname:node_4200,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.191547,max:2;n:type:ShaderForge.SFN_Floor,id:7255,x:33136,y:32258,varname:node_7255,prsc:2|IN-301-OUT;n:type:ShaderForge.SFN_RemapRange,id:301,x:32961,y:32258,varname:node_301,prsc:2,frmn:0,frmx:1,tomn:0,tomx:2;n:type:ShaderForge.SFN_Floor,id:1523,x:33200,y:32322,varname:node_1523,prsc:2|IN-1500-OUT;n:type:ShaderForge.SFN_RemapRange,id:1500,x:33025,y:32322,varname:node_1500,prsc:2,frmn:0,frmx:1,tomn:0,tomx:2;n:type:ShaderForge.SFN_Slider,id:7630,x:30515,y:32563,ptovrint:False,ptlb:Rotation V,ptin:_RotationV,varname:_node_4200_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.278614,max:2;proporder:7241-2319-5383-2318-4200-7630;pass:END;sub:END;*/

Shader "Shader Forge/Core_Effect" {
    Properties {
        _Color ("Color", Color) = (0.07843138,0.3921569,0.7843137,1)
        _node_2319 ("node_2319", 2D) = "white" {}
        _Brightness ("Brightness", Float ) = 1
        _MaxBrightness ("Max Brightness", Float ) = 1
        _RotationU ("Rotation U", Range(0, 2)) = 1.191547
        _RotationV ("Rotation V", Range(0, 2)) = 1.278614
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
            Blend SrcAlpha One
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
            uniform sampler2D _node_2319; uniform float4 _node_2319_ST;
            uniform float _Brightness;
            uniform float _MaxBrightness;
            uniform float _RotationU;
            uniform float _RotationV;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
////// Lighting:
////// Emissive:
                float4 node_6795 = _Time;
                float2 node_981 = float2(_RotationU,_RotationV);
                float node_4379_ang = node_6795.g;
                float node_4379_spd = (-1.0);
                float node_4379_cos = cos(node_4379_spd*node_4379_ang);
                float node_4379_sin = sin(node_4379_spd*node_4379_ang);
                float2 node_4379_piv = node_981;
                float2 node_5962 = (i.uv0*3.0);
                float2 node_4379 = (mul(node_5962-node_4379_piv,float2x2( node_4379_cos, -node_4379_sin, node_4379_sin, node_4379_cos))+node_4379_piv);
                float2 node_5981 = (node_4379+node_6795.g*float2(-0.1,-0.6));
                float4 node_8198 = tex2D(_node_2319,TRANSFORM_TEX(node_5981, _node_2319));
                float node_3504_ang = node_6795.g;
                float node_3504_spd = 0.3;
                float node_3504_cos = cos(node_3504_spd*node_3504_ang);
                float node_3504_sin = sin(node_3504_spd*node_3504_ang);
                float2 node_3504_piv = node_981;
                float2 node_3504 = (mul(node_5962-node_3504_piv,float2x2( node_3504_cos, -node_3504_sin, node_3504_sin, node_3504_cos))+node_3504_piv);
                float2 node_6244 = (node_3504+node_6795.g*float2(0.5,0.1));
                float4 _node_8198_copy = tex2D(_node_2319,TRANSFORM_TEX(node_6244, _node_2319));
                float node_3416 = (1.0 - saturate(abs(node_8198.r-_node_8198_copy.r)));
                float3 emissive = min((saturate((1.0-((1.0-node_3416)/(((2.0*pow(1.0-max(0,dot(normalDirection, viewDirection)),3.0))*_Color.rgb)+_Color.rgb))))*_Brightness),_MaxBrightness);
                float3 finalColor = emissive;
                return fixed4(finalColor,saturate((node_3416*2.0+-1.0)));
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
