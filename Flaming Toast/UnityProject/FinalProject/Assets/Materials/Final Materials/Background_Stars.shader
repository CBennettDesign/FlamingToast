// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33685,y:32734,varname:node_3138,prsc:2|emission-6352-OUT;n:type:ShaderForge.SFN_Tex2d,id:3953,x:31813,y:32651,varname:node_3953,prsc:2,tex:930a73848f3a9c943a0a222bca4f3961,ntxv:0,isnm:False|UVIN-920-UVOUT,TEX-2058-TEX;n:type:ShaderForge.SFN_Tex2d,id:8078,x:31813,y:32833,varname:_node_3953_copy,prsc:2,tex:930a73848f3a9c943a0a222bca4f3961,ntxv:0,isnm:False|UVIN-7253-UVOUT,TEX-2058-TEX;n:type:ShaderForge.SFN_Tex2d,id:4400,x:31813,y:33014,varname:_node_3953_copy_copy,prsc:2,tex:930a73848f3a9c943a0a222bca4f3961,ntxv:0,isnm:False|UVIN-9061-UVOUT,TEX-2058-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:2058,x:31588,y:33192,ptovrint:False,ptlb:Texture(Stars),ptin:_TextureStars,varname:node_2058,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:930a73848f3a9c943a0a222bca4f3961,ntxv:0,isnm:False;n:type:ShaderForge.SFN_TexCoord,id:8429,x:30819,y:33144,varname:node_8429,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:920,x:31588,y:32651,cmnt:speed,varname:node_920,prsc:2,spu:0.01,spv:0|UVIN-9426-OUT,DIST-8652-OUT;n:type:ShaderForge.SFN_Panner,id:7253,x:31588,y:32833,varname:node_7253,prsc:2,spu:0.02,spv:0|UVIN-1707-OUT,DIST-8652-OUT;n:type:ShaderForge.SFN_Panner,id:9061,x:31588,y:33014,varname:node_9061,prsc:2,spu:0.03,spv:0|UVIN-8133-OUT,DIST-8652-OUT;n:type:ShaderForge.SFN_Blend,id:1025,x:32663,y:32831,varname:node_1025,prsc:2,blmd:6,clmp:True|SRC-1974-OUT,DST-851-OUT;n:type:ShaderForge.SFN_Multiply,id:7725,x:32003,y:32651,cmnt:brightness,varname:node_7725,prsc:2|A-3953-A,B-8006-OUT;n:type:ShaderForge.SFN_Vector1,id:8006,x:31813,y:32772,varname:node_8006,prsc:2,v1:2;n:type:ShaderForge.SFN_Vector1,id:3350,x:31813,y:32961,varname:node_3350,prsc:2,v1:3.5;n:type:ShaderForge.SFN_Vector1,id:8312,x:31813,y:33139,varname:node_8312,prsc:2,v1:10;n:type:ShaderForge.SFN_Multiply,id:851,x:32003,y:32833,varname:node_851,prsc:2|A-8078-B,B-3350-OUT;n:type:ShaderForge.SFN_Multiply,id:7017,x:32003,y:33014,varname:node_7017,prsc:2|A-4400-G,B-8312-OUT;n:type:ShaderForge.SFN_Blend,id:7669,x:32856,y:32953,varname:node_7669,prsc:2,blmd:6,clmp:True|SRC-1025-OUT,DST-7017-OUT;n:type:ShaderForge.SFN_Time,id:7540,x:30588,y:32999,varname:node_7540,prsc:2;n:type:ShaderForge.SFN_Multiply,id:8652,x:30819,y:33010,varname:node_8652,prsc:2|A-7540-T,B-338-OUT;n:type:ShaderForge.SFN_ValueProperty,id:338,x:30588,y:33144,ptovrint:False,ptlb:Speed,ptin:_Speed,varname:node_338,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Panner,id:3083,x:31588,y:33381,varname:node_3083,prsc:2,spu:0.02,spv:0|UVIN-8429-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:1659,x:31813,y:33381,varname:_MaskClouds_copy,prsc:2,tex:930a73848f3a9c943a0a222bca4f3961,ntxv:0,isnm:False|UVIN-3083-UVOUT,TEX-2058-TEX;n:type:ShaderForge.SFN_Multiply,id:8133,x:31419,y:33014,varname:node_8133,prsc:2|A-8429-UVOUT,B-9552-OUT;n:type:ShaderForge.SFN_Multiply,id:1707,x:31419,y:32833,varname:node_1707,prsc:2|A-8429-UVOUT,B-5511-OUT;n:type:ShaderForge.SFN_Multiply,id:9426,x:31419,y:32651,cmnt:scaling,varname:node_9426,prsc:2|A-8429-UVOUT,B-5492-OUT;n:type:ShaderForge.SFN_Vector1,id:9552,x:31419,y:33143,varname:node_9552,prsc:2,v1:1.2;n:type:ShaderForge.SFN_Vector1,id:5511,x:31419,y:32956,varname:node_5511,prsc:2,v1:1.1;n:type:ShaderForge.SFN_Vector1,id:5492,x:31419,y:32772,varname:node_5492,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:6352,x:33412,y:32809,varname:node_6352,prsc:2|A-9474-OUT,B-9845-OUT;n:type:ShaderForge.SFN_Vector1,id:9474,x:32957,y:32724,varname:node_9474,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:8430,x:32012,y:33381,cmnt:adding dark blue,varname:node_8430,prsc:2|A-1659-R,B-6082-OUT,C-1054-OUT;n:type:ShaderForge.SFN_Vector3,id:6082,x:31813,y:33504,varname:node_6082,prsc:2,v1:0,v2:0.5176468,v3:1;n:type:ShaderForge.SFN_Blend,id:9845,x:33127,y:33169,cmnt:blending dark blue,varname:node_9845,prsc:2,blmd:8,clmp:False|SRC-7669-OUT,DST-2729-OUT;n:type:ShaderForge.SFN_Vector1,id:1054,x:31813,y:33593,varname:node_1054,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Vector3,id:8902,x:32276,y:32492,varname:node_8902,prsc:2,v1:0.04411763,v2:0.04411763,v3:0.04411763;n:type:ShaderForge.SFN_Blend,id:1974,x:32443,y:32649,varname:node_1974,prsc:2,blmd:6,clmp:True|SRC-8902-OUT,DST-7725-OUT;n:type:ShaderForge.SFN_Blend,id:2729,x:32225,y:33381,varname:node_2729,prsc:2,blmd:7,clmp:False|SRC-8430-OUT,DST-8430-OUT;proporder:2058-1901-338;pass:END;sub:END;*/

Shader "Shader Forge/Star_Background" {
    Properties {
        _TextureStars ("Texture(Stars)", 2D) = "white" {}
        _ ("", 2D) = "white" {}
        _Speed ("Speed", Float ) = 1
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _TextureStars; uniform float4 _TextureStars_ST;
            uniform float _Speed;
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
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 node_7540 = _Time;
                float node_8652 = (node_7540.g*_Speed);
                float2 node_920 = ((i.uv0*1.0)+node_8652*float2(0.01,0)); // speed
                float4 node_3953 = tex2D(_TextureStars,TRANSFORM_TEX(node_920, _TextureStars));
                float node_7725 = (node_3953.a*2.0); // brightness
                float2 node_7253 = ((i.uv0*1.1)+node_8652*float2(0.02,0));
                float4 _node_3953_copy = tex2D(_TextureStars,TRANSFORM_TEX(node_7253, _TextureStars));
                float2 node_9061 = ((i.uv0*1.2)+node_8652*float2(0.03,0));
                float4 _node_3953_copy_copy = tex2D(_TextureStars,TRANSFORM_TEX(node_9061, _TextureStars));
                float4 node_1460 = _Time;
                float2 node_3083 = (i.uv0+node_1460.g*float2(0.02,0));
                float4 _MaskClouds_copy = tex2D(_TextureStars,TRANSFORM_TEX(node_3083, _TextureStars));
                float3 node_8430 = (_MaskClouds_copy.r*float3(0,0.5176468,1)*0.5); // adding dark blue
                float3 emissive = (1.0*(saturate((1.0-(1.0-saturate((1.0-(1.0-saturate((1.0-(1.0-float3(0.04411763,0.04411763,0.04411763))*(1.0-node_7725))))*(1.0-(_node_3953_copy.b*3.5)))))*(1.0-(_node_3953_copy_copy.g*10.0))))+(node_8430/(1.0-node_8430))));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
