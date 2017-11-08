// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33357,y:32719,varname:node_3138,prsc:2|emission-6352-OUT;n:type:ShaderForge.SFN_Tex2d,id:3953,x:31813,y:32651,varname:node_3953,prsc:2,tex:5ac8fb6a4f096e948b9b4a365d0e8da0,ntxv:0,isnm:False|UVIN-920-UVOUT,TEX-2058-TEX;n:type:ShaderForge.SFN_Tex2d,id:8078,x:31813,y:32833,varname:_node_3953_copy,prsc:2,tex:5ac8fb6a4f096e948b9b4a365d0e8da0,ntxv:0,isnm:False|UVIN-7253-UVOUT,TEX-2058-TEX;n:type:ShaderForge.SFN_Tex2d,id:4400,x:31813,y:33014,varname:_node_3953_copy_copy,prsc:2,tex:5ac8fb6a4f096e948b9b4a365d0e8da0,ntxv:0,isnm:False|UVIN-9061-UVOUT,TEX-2058-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:2058,x:31588,y:32485,ptovrint:False,ptlb:Texture(Stars),ptin:_TextureStars,varname:node_2058,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:5ac8fb6a4f096e948b9b4a365d0e8da0,ntxv:0,isnm:False;n:type:ShaderForge.SFN_TexCoord,id:8429,x:30819,y:33144,varname:node_8429,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:920,x:31588,y:32651,varname:node_920,prsc:2,spu:0.01,spv:0|UVIN-9426-OUT,DIST-8652-OUT;n:type:ShaderForge.SFN_Panner,id:7253,x:31588,y:32833,varname:node_7253,prsc:2,spu:0.03,spv:0|UVIN-1707-OUT,DIST-8652-OUT;n:type:ShaderForge.SFN_Panner,id:9061,x:31588,y:33014,varname:node_9061,prsc:2,spu:0.06,spv:0|UVIN-8133-OUT,DIST-8652-OUT;n:type:ShaderForge.SFN_Blend,id:1025,x:32432,y:32740,varname:node_1025,prsc:2,blmd:5,clmp:True|SRC-8393-OUT,DST-304-OUT;n:type:ShaderForge.SFN_Multiply,id:7725,x:32003,y:32651,varname:node_7725,prsc:2|A-3953-R,B-8006-OUT;n:type:ShaderForge.SFN_Vector1,id:8006,x:31813,y:32772,varname:node_8006,prsc:2,v1:2;n:type:ShaderForge.SFN_Vector1,id:3350,x:31813,y:32961,varname:node_3350,prsc:2,v1:4;n:type:ShaderForge.SFN_Vector1,id:8312,x:31813,y:33139,varname:node_8312,prsc:2,v1:6;n:type:ShaderForge.SFN_Multiply,id:851,x:32003,y:32833,varname:node_851,prsc:2|A-8078-R,B-3350-OUT;n:type:ShaderForge.SFN_Multiply,id:7017,x:32003,y:33014,varname:node_7017,prsc:2|A-4400-R,B-8312-OUT;n:type:ShaderForge.SFN_Blend,id:7669,x:32604,y:32922,varname:node_7669,prsc:2,blmd:5,clmp:True|SRC-1025-OUT,DST-5572-OUT;n:type:ShaderForge.SFN_Tex2d,id:2076,x:32003,y:33223,varname:node_2076,prsc:2,ntxv:0,isnm:False|UVIN-667-UVOUT,TEX-4231-TEX;n:type:ShaderForge.SFN_Panner,id:667,x:31813,y:33223,varname:node_667,prsc:2,spu:-0.03,spv:0|UVIN-8429-UVOUT;n:type:ShaderForge.SFN_Blend,id:5572,x:32230,y:33014,cmnt:Front,varname:node_5572,prsc:2,blmd:3,clmp:True|SRC-7017-OUT,DST-8723-R;n:type:ShaderForge.SFN_Blend,id:304,x:32230,y:32833,cmnt:Middle,varname:node_304,prsc:2,blmd:1,clmp:True|SRC-851-OUT,DST-1659-R;n:type:ShaderForge.SFN_Blend,id:8393,x:32230,y:32651,cmnt:Back,varname:node_8393,prsc:2,blmd:1,clmp:True|SRC-7725-OUT,DST-2076-R;n:type:ShaderForge.SFN_Time,id:7540,x:30588,y:32999,varname:node_7540,prsc:2;n:type:ShaderForge.SFN_Multiply,id:8652,x:30819,y:33010,varname:node_8652,prsc:2|A-7540-T,B-338-OUT;n:type:ShaderForge.SFN_ValueProperty,id:338,x:30588,y:33144,ptovrint:False,ptlb:Speed,ptin:_Speed,varname:node_338,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Panner,id:3083,x:31813,y:33415,varname:node_3083,prsc:2,spu:0.06,spv:0|UVIN-8429-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:1659,x:32003,y:33415,varname:_MaskClouds_copy,prsc:2,ntxv:0,isnm:False|UVIN-3083-UVOUT,TEX-4231-TEX;n:type:ShaderForge.SFN_Panner,id:3281,x:31813,y:33604,varname:node_3281,prsc:2,spu:-0.04,spv:0.02|UVIN-8429-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:8723,x:32003,y:33604,varname:_MaskClouds_copy_copy,prsc:2,ntxv:0,isnm:False|UVIN-3281-UVOUT,TEX-4231-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:4231,x:31813,y:33782,ptovrint:False,ptlb:node_4231,ptin:_node_4231,varname:node_4231,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:8133,x:31419,y:33014,varname:node_8133,prsc:2|A-8429-UVOUT,B-9552-OUT;n:type:ShaderForge.SFN_Multiply,id:1707,x:31419,y:32833,varname:node_1707,prsc:2|A-8429-UVOUT,B-5511-OUT;n:type:ShaderForge.SFN_Multiply,id:9426,x:31419,y:32651,varname:node_9426,prsc:2|A-8429-UVOUT,B-5492-OUT;n:type:ShaderForge.SFN_Vector1,id:9552,x:31419,y:33143,varname:node_9552,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Vector1,id:5511,x:31419,y:32956,varname:node_5511,prsc:2,v1:0.7;n:type:ShaderForge.SFN_Vector1,id:5492,x:31419,y:32772,varname:node_5492,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:6352,x:33077,y:32855,varname:node_6352,prsc:2|A-9474-OUT,B-9845-OUT;n:type:ShaderForge.SFN_Vector1,id:9474,x:32814,y:32821,varname:node_9474,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:8430,x:32536,y:33199,varname:node_8430,prsc:2|A-1659-R,B-6082-OUT;n:type:ShaderForge.SFN_Vector3,id:6082,x:32318,y:33490,varname:node_6082,prsc:2,v1:0,v2:0.03402635,v3:0.08088237;n:type:ShaderForge.SFN_Blend,id:9845,x:32834,y:32940,varname:node_9845,prsc:2,blmd:8,clmp:True|SRC-7669-OUT,DST-8430-OUT;proporder:2058-338-4231;pass:END;sub:END;*/

Shader "Shader Forge/Star_Background" {
    Properties {
        _TextureStars ("Texture(Stars)", 2D) = "white" {}
        _Speed ("Speed", Float ) = 2
        _node_4231 ("node_4231", 2D) = "white" {}
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
            uniform sampler2D _node_4231; uniform float4 _node_4231_ST;
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
                float2 node_920 = ((i.uv0*1.0)+node_8652*float2(0.01,0));
                float4 node_3953 = tex2D(_TextureStars,TRANSFORM_TEX(node_920, _TextureStars));
                float4 node_2305 = _Time;
                float2 node_667 = (i.uv0+node_2305.g*float2(-0.03,0));
                float4 node_2076 = tex2D(_node_4231,TRANSFORM_TEX(node_667, _node_4231));
                float2 node_7253 = ((i.uv0*0.7)+node_8652*float2(0.03,0));
                float4 _node_3953_copy = tex2D(_TextureStars,TRANSFORM_TEX(node_7253, _TextureStars));
                float2 node_3083 = (i.uv0+node_2305.g*float2(0.06,0));
                float4 _MaskClouds_copy = tex2D(_node_4231,TRANSFORM_TEX(node_3083, _node_4231));
                float2 node_9061 = ((i.uv0*0.5)+node_8652*float2(0.06,0));
                float4 _node_3953_copy_copy = tex2D(_TextureStars,TRANSFORM_TEX(node_9061, _TextureStars));
                float2 node_3281 = (i.uv0+node_2305.g*float2(-0.04,0.02));
                float4 _MaskClouds_copy_copy = tex2D(_node_4231,TRANSFORM_TEX(node_3281, _node_4231));
                float3 emissive = (1.0*saturate((saturate(max(saturate(max(saturate(((node_3953.r*2.0)*node_2076.r)),saturate(((_node_3953_copy.r*4.0)*_MaskClouds_copy.r)))),saturate(((_node_3953_copy_copy.r*6.0)+_MaskClouds_copy_copy.r-1.0))))+(_MaskClouds_copy.r*float3(0,0.03402635,0.08088237)))));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
