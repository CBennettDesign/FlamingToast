// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:0,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:0,dpts:6,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:False,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:33823,y:32918,varname:node_2865,prsc:2|emission-483-OUT,alpha-2203-OUT;n:type:ShaderForge.SFN_TexCoord,id:2073,x:29834,y:32083,varname:node_2073,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:2925,x:30726,y:32063,varname:node_2925,prsc:2,spu:0.03,spv:0.1|UVIN-475-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:7372,x:30726,y:32442,ptovrint:False,ptlb:Cloud Texture,ptin:_CloudTexture,varname:_CloudTexture,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:3630,x:30918,y:32063,varname:node_5117,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-2925-UVOUT,TEX-7372-TEX;n:type:ShaderForge.SFN_Panner,id:8332,x:30726,y:32233,varname:node_8332,prsc:2,spu:-0.01,spv:0.02|UVIN-9-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:7368,x:30918,y:32233,varname:_node_7358_copy,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-8332-UVOUT,TEX-7372-TEX;n:type:ShaderForge.SFN_Blend,id:775,x:31174,y:32141,varname:node_775,prsc:2,blmd:17,clmp:True|SRC-3630-R,DST-7368-R;n:type:ShaderForge.SFN_Rotator,id:9,x:30528,y:32243,varname:node_9,prsc:2|UVIN-475-OUT,SPD-7389-OUT;n:type:ShaderForge.SFN_Vector1,id:7389,x:30321,y:32371,varname:node_7389,prsc:2,v1:0.1;n:type:ShaderForge.SFN_VertexColor,id:7873,x:30440,y:32970,varname:node_7873,prsc:2;n:type:ShaderForge.SFN_ChannelBlend,id:9268,x:31717,y:33345,varname:node_9268,prsc:2,chbt:0|M-696-OUT,R-8501-OUT,G-8501-OUT,B-8501-OUT,A-8501-OUT;n:type:ShaderForge.SFN_Append,id:696,x:31495,y:33256,varname:node_696,prsc:2|A-4968-OUT,B-8247-OUT,C-8663-OUT,D-2242-OUT;n:type:ShaderForge.SFN_Multiply,id:4968,x:31292,y:33099,varname:node_4968,prsc:2|A-7873-R,B-6897-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6518,x:30712,y:33575,ptovrint:False,ptlb:Shield_Bottom,ptin:_Shield_Bottom,varname:_Shield_Bottom,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:9983,x:30718,y:33405,ptovrint:False,ptlb:Shield_Left,ptin:_Shield_Left,varname:_Shield_Left,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:5705,x:30718,y:33288,ptovrint:False,ptlb:Shield_Right,ptin:_Shield_Right,varname:_Shield_Right,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:2500,x:30718,y:33150,ptovrint:False,ptlb:Shield_Top,ptin:_Shield_Top,varname:_Shield_Top,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:8247,x:31276,y:33227,varname:node_8247,prsc:2|A-7873-G,B-159-OUT;n:type:ShaderForge.SFN_Multiply,id:8663,x:31276,y:33365,varname:node_8663,prsc:2|A-7873-B,B-9930-OUT;n:type:ShaderForge.SFN_Multiply,id:2242,x:31276,y:33506,varname:node_2242,prsc:2|A-7873-A,B-9305-OUT;n:type:ShaderForge.SFN_Clamp01,id:6897,x:30959,y:33103,varname:node_6897,prsc:2|IN-2500-OUT;n:type:ShaderForge.SFN_Clamp01,id:159,x:30959,y:33254,varname:node_159,prsc:2|IN-5705-OUT;n:type:ShaderForge.SFN_Clamp01,id:9930,x:30959,y:33392,varname:node_9930,prsc:2|IN-9983-OUT;n:type:ShaderForge.SFN_Clamp01,id:9305,x:30959,y:33541,varname:node_9305,prsc:2|IN-6518-OUT;n:type:ShaderForge.SFN_Vector1,id:8501,x:31495,y:33389,varname:node_8501,prsc:2,v1:1;n:type:ShaderForge.SFN_Blend,id:9252,x:32166,y:33033,varname:node_9252,prsc:2,blmd:19,clmp:True|SRC-775-OUT,DST-9268-OUT;n:type:ShaderForge.SFN_Color,id:1080,x:33150,y:32803,ptovrint:False,ptlb:Colour,ptin:_Colour,varname:_Colour,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Relay,id:3242,x:31077,y:32897,cmnt:Directions of the shield using vertex painting,varname:node_3242,prsc:2;n:type:ShaderForge.SFN_Relay,id:3742,x:30819,y:31960,cmnt:Cloudy effect,varname:node_3742,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:5253,x:31931,y:33644,ptovrint:False,ptlb:Pattern Tile Texture,ptin:_PatternTileTexture,varname:_PatternTileTexture,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-7193-OUT;n:type:ShaderForge.SFN_Blend,id:9625,x:32716,y:33170,varname:node_9625,prsc:2,blmd:3,clmp:True|SRC-9252-OUT,DST-2907-OUT;n:type:ShaderForge.SFN_OneMinus,id:272,x:32142,y:33696,varname:node_272,prsc:2|IN-5253-R;n:type:ShaderForge.SFN_TexCoord,id:7496,x:31397,y:33661,varname:node_7496,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:5807,x:31558,y:33661,varname:node_5807,prsc:2|A-7496-UVOUT,B-2353-OUT;n:type:ShaderForge.SFN_Frac,id:7193,x:31714,y:33661,varname:node_7193,prsc:2|IN-5807-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2353,x:31397,y:33834,ptovrint:False,ptlb:Pattern Tile Amount,ptin:_PatternTileAmount,varname:_PatternTileAmount,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-1;n:type:ShaderForge.SFN_SwitchProperty,id:2907,x:32396,y:33590,ptovrint:False,ptlb:Invert?,ptin:_Invert,varname:_Invert,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-5253-R,B-272-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9641,x:32634,y:33439,ptovrint:False,ptlb:Overall Transparency,ptin:_OverallTransparency,varname:_OverallTransparency,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:261,x:33000,y:33253,varname:node_261,prsc:2|A-9625-OUT,B-9641-OUT;n:type:ShaderForge.SFN_Multiply,id:3786,x:30088,y:32083,varname:node_3786,prsc:2|A-2073-UVOUT,B-1932-OUT;n:type:ShaderForge.SFN_Frac,id:475,x:30253,y:32083,varname:node_475,prsc:2|IN-3786-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1932,x:29834,y:32253,ptovrint:False,ptlb:Effect Tile Amount,ptin:_EffectTileAmount,varname:_EffectTileAmount,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Clamp01,id:2203,x:33576,y:33181,varname:node_2203,prsc:2|IN-5033-OUT;n:type:ShaderForge.SFN_Tex2d,id:1282,x:32868,y:34054,ptovrint:False,ptlb:mask,ptin:_mask,varname:_mask,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:c800914fb3515ee4287e0c5a8a0f1670,ntxv:0,isnm:False|UVIN-2381-UVOUT;n:type:ShaderForge.SFN_Multiply,id:496,x:33262,y:33418,varname:node_496,prsc:2|A-5624-OUT,B-6517-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5624,x:33044,y:33418,ptovrint:False,ptlb:mask multiplyer,ptin:_maskmultiplyer,varname:_maskmultiplyer,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_TexCoord,id:2639,x:31337,y:34155,varname:node_2639,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Rotator,id:2381,x:32679,y:34107,varname:node_2381,prsc:2|UVIN-1846-UVOUT,ANG-108-OUT;n:type:ShaderForge.SFN_ValueProperty,id:108,x:32474,y:34291,ptovrint:False,ptlb:mask rotation,ptin:_maskrotation,varname:_maskrotation,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Subtract,id:5033,x:33262,y:33252,varname:node_5033,prsc:2|A-261-OUT,B-496-OUT;n:type:ShaderForge.SFN_RemapRange,id:8058,x:33115,y:34032,varname:node_8058,prsc:2,frmn:0,frmx:1,tomn:-0.1,tomx:1|IN-1282-R;n:type:ShaderForge.SFN_Clamp01,id:3520,x:33279,y:34012,varname:node_3520,prsc:2|IN-8058-OUT;n:type:ShaderForge.SFN_Multiply,id:483,x:33573,y:32936,varname:node_483,prsc:2|A-1080-RGB,B-8442-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8442,x:33150,y:32991,ptovrint:False,ptlb:Emission Amount,ptin:_EmissionAmount,varname:node_8442,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Panner,id:1846,x:32265,y:34108,varname:node_1846,prsc:2,spu:-0.06,spv:-0.34|UVIN-2009-OUT,DIST-9040-OUT;n:type:ShaderForge.SFN_Vector1,id:9040,x:31949,y:34208,varname:node_9040,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:2009,x:31949,y:34076,varname:node_2009,prsc:2|A-7698-OUT,B-3370-OUT;n:type:ShaderForge.SFN_Slider,id:7698,x:31574,y:34024,ptovrint:False,ptlb:Mask_Size,ptin:_Mask_Size,varname:node_7698,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-2,cur:0,max:2;n:type:ShaderForge.SFN_OneMinus,id:6517,x:33510,y:33903,varname:node_6517,prsc:2|IN-3520-OUT;n:type:ShaderForge.SFN_OneMinus,id:1018,x:31552,y:34233,varname:node_1018,prsc:2|IN-2639-V;n:type:ShaderForge.SFN_Append,id:3370,x:31731,y:34121,varname:node_3370,prsc:2|A-2639-U,B-1018-OUT;proporder:7372-1932-2500-9983-5705-6518-9641-1080-5253-2353-2907-1282-5624-108-8442-7698;pass:END;sub:END;*/

Shader "Shader Forge/Test3" {
    Properties {
        _CloudTexture ("Cloud Texture", 2D) = "white" {}
        _EffectTileAmount ("Effect Tile Amount", Float ) = 1
        _Shield_Top ("Shield_Top", Float ) = 1
        _Shield_Left ("Shield_Left", Float ) = 1
        _Shield_Right ("Shield_Right", Float ) = 1
        _Shield_Bottom ("Shield_Bottom", Float ) = 1
        _OverallTransparency ("Overall Transparency", Float ) = 0
        _Colour ("Colour", Color) = (0.5,0.5,0.5,1)
        _PatternTileTexture ("Pattern Tile Texture", 2D) = "white" {}
        _PatternTileAmount ("Pattern Tile Amount", Float ) = -1
        [MaterialToggle] _Invert ("Invert?", Float ) = 0
        _mask ("mask", 2D) = "white" {}
        _maskmultiplyer ("mask multiplyer", Float ) = 0
        _maskrotation ("mask rotation", Float ) = 0
        _EmissionAmount ("Emission Amount", Float ) = 0
        _Mask_Size ("Mask_Size", Range(-2, 2)) = 0
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
            ZTest Always
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _CloudTexture; uniform float4 _CloudTexture_ST;
            uniform float _Shield_Bottom;
            uniform float _Shield_Left;
            uniform float _Shield_Right;
            uniform float _Shield_Top;
            uniform float4 _Colour;
            uniform sampler2D _PatternTileTexture; uniform float4 _PatternTileTexture_ST;
            uniform float _PatternTileAmount;
            uniform fixed _Invert;
            uniform float _OverallTransparency;
            uniform float _EffectTileAmount;
            uniform sampler2D _mask; uniform float4 _mask_ST;
            uniform float _maskmultiplyer;
            uniform float _maskrotation;
            uniform float _EmissionAmount;
            uniform float _Mask_Size;
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
                float3 emissive = (_Colour.rgb*_EmissionAmount);
                float3 finalColor = emissive;
                float4 node_2364 = _Time;
                float2 node_475 = frac((i.uv0*_EffectTileAmount));
                float2 node_2925 = (node_475+node_2364.g*float2(0.03,0.1));
                float4 node_5117 = tex2D(_CloudTexture,TRANSFORM_TEX(node_2925, _CloudTexture));
                float node_9_ang = node_2364.g;
                float node_9_spd = 0.1;
                float node_9_cos = cos(node_9_spd*node_9_ang);
                float node_9_sin = sin(node_9_spd*node_9_ang);
                float2 node_9_piv = float2(0.5,0.5);
                float2 node_9 = (mul(node_475-node_9_piv,float2x2( node_9_cos, -node_9_sin, node_9_sin, node_9_cos))+node_9_piv);
                float2 node_8332 = (node_9+node_2364.g*float2(-0.01,0.02));
                float4 _node_7358_copy = tex2D(_CloudTexture,TRANSFORM_TEX(node_8332, _CloudTexture));
                float4 node_696 = float4((i.vertexColor.r*saturate(_Shield_Top)),(i.vertexColor.g*saturate(_Shield_Right)),(i.vertexColor.b*saturate(_Shield_Left)),(i.vertexColor.a*saturate(_Shield_Bottom)));
                float node_8501 = 1.0;
                float2 node_7193 = frac((i.uv0*_PatternTileAmount));
                float4 _PatternTileTexture_var = tex2D(_PatternTileTexture,TRANSFORM_TEX(node_7193, _PatternTileTexture));
                float node_2381_ang = _maskrotation;
                float node_2381_spd = 1.0;
                float node_2381_cos = cos(node_2381_spd*node_2381_ang);
                float node_2381_sin = sin(node_2381_spd*node_2381_ang);
                float2 node_2381_piv = float2(0.5,0.5);
                float2 node_2381 = (mul(((_Mask_Size*float2(i.uv0.r,(1.0 - i.uv0.g)))+1.0*float2(-0.06,-0.34))-node_2381_piv,float2x2( node_2381_cos, -node_2381_sin, node_2381_sin, node_2381_cos))+node_2381_piv);
                float4 _mask_var = tex2D(_mask,TRANSFORM_TEX(node_2381, _mask));
                fixed4 finalRGBA = fixed4(finalColor,saturate(((saturate((saturate(((node_696.r*node_8501 + node_696.g*node_8501 + node_696.b*node_8501 + node_696.a*node_8501)-saturate(abs(node_5117.r-_node_7358_copy.r))))+lerp( _PatternTileTexture_var.r, (1.0 - _PatternTileTexture_var.r), _Invert )-1.0))*_OverallTransparency)-(_maskmultiplyer*(1.0 - saturate((_mask_var.r*1.1+-0.1)))))));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _Colour;
            uniform float _EmissionAmount;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                o.Emission = (_Colour.rgb*_EmissionAmount);
                
                float3 diffColor = float3(0,0,0);
                o.Albedo = diffColor;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
