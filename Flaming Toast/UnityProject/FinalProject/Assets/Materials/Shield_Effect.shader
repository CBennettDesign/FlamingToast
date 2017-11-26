// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:0,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:0,dpts:6,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:False,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:33444,y:32621,varname:node_2865,prsc:2|emission-483-OUT,alpha-9128-OUT,voffset-4189-OUT;n:type:ShaderForge.SFN_TexCoord,id:2073,x:29977,y:32082,varname:node_2073,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:2925,x:30726,y:32063,varname:node_2925,prsc:2,spu:0.03,spv:0.1|UVIN-475-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:7372,x:30726,y:32442,ptovrint:False,ptlb:Cloud Texture,ptin:_CloudTexture,varname:_CloudTexture,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:3630,x:30918,y:32063,varname:node_5117,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-2925-UVOUT,TEX-7372-TEX;n:type:ShaderForge.SFN_Panner,id:8332,x:30726,y:32233,varname:node_8332,prsc:2,spu:-0.01,spv:0.02|UVIN-9-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:7368,x:30918,y:32233,varname:_node_7358_copy,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-8332-UVOUT,TEX-7372-TEX;n:type:ShaderForge.SFN_Blend,id:775,x:31174,y:32141,varname:node_775,prsc:2,blmd:17,clmp:True|SRC-3630-R,DST-7368-R;n:type:ShaderForge.SFN_Rotator,id:9,x:30530,y:32233,varname:node_9,prsc:2|UVIN-475-OUT,SPD-7389-OUT;n:type:ShaderForge.SFN_Vector1,id:7389,x:30331,y:32233,varname:node_7389,prsc:2,v1:0.1;n:type:ShaderForge.SFN_VertexColor,id:7873,x:31300,y:33063,varname:node_7873,prsc:2;n:type:ShaderForge.SFN_ChannelBlend,id:9268,x:32577,y:33438,varname:node_9268,prsc:2,chbt:0|M-696-OUT,R-8501-OUT,G-8501-OUT,B-8501-OUT,A-8501-OUT;n:type:ShaderForge.SFN_Append,id:696,x:32355,y:33349,varname:node_696,prsc:2|A-4968-OUT,B-8247-OUT,C-8663-OUT,D-2242-OUT;n:type:ShaderForge.SFN_Multiply,id:4968,x:32152,y:33192,varname:node_4968,prsc:2|A-7873-R,B-6897-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6518,x:31572,y:33668,ptovrint:False,ptlb:Shield_Bottom,ptin:_Shield_Bottom,varname:_Shield_Bottom,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:9983,x:31578,y:33498,ptovrint:False,ptlb:Shield_Left,ptin:_Shield_Left,varname:_Shield_Left,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:5705,x:31578,y:33381,ptovrint:False,ptlb:Shield_Right,ptin:_Shield_Right,varname:_Shield_Right,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:2500,x:31578,y:33243,ptovrint:False,ptlb:Shield_Top,ptin:_Shield_Top,varname:_Shield_Top,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:8247,x:32136,y:33320,varname:node_8247,prsc:2|A-7873-G,B-159-OUT;n:type:ShaderForge.SFN_Multiply,id:8663,x:32136,y:33458,varname:node_8663,prsc:2|A-7873-B,B-9930-OUT;n:type:ShaderForge.SFN_Multiply,id:2242,x:32136,y:33599,varname:node_2242,prsc:2|A-7873-A,B-9305-OUT;n:type:ShaderForge.SFN_Clamp01,id:6897,x:31819,y:33196,varname:node_6897,prsc:2|IN-2500-OUT;n:type:ShaderForge.SFN_Clamp01,id:159,x:31819,y:33347,varname:node_159,prsc:2|IN-5705-OUT;n:type:ShaderForge.SFN_Clamp01,id:9930,x:31819,y:33485,varname:node_9930,prsc:2|IN-9983-OUT;n:type:ShaderForge.SFN_Clamp01,id:9305,x:31819,y:33634,varname:node_9305,prsc:2|IN-6518-OUT;n:type:ShaderForge.SFN_Vector1,id:8501,x:32355,y:33482,varname:node_8501,prsc:2,v1:1;n:type:ShaderForge.SFN_Blend,id:9252,x:32867,y:33053,varname:node_9252,prsc:2,blmd:1,clmp:True|SRC-3413-OUT,DST-9268-OUT;n:type:ShaderForge.SFN_Color,id:1080,x:33005,y:32370,ptovrint:False,ptlb:Colour,ptin:_Colour,varname:_Colour,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Relay,id:3242,x:31878,y:33128,cmnt:Masking the directions of the shield using vertex painting,varname:node_3242,prsc:2;n:type:ShaderForge.SFN_Relay,id:3742,x:30819,y:31960,cmnt:Cloudy effect,varname:node_3742,prsc:2;n:type:ShaderForge.SFN_Multiply,id:3786,x:30154,y:32082,varname:node_3786,prsc:2|A-2073-UVOUT,B-1932-OUT;n:type:ShaderForge.SFN_Frac,id:475,x:30331,y:32082,varname:node_475,prsc:2|IN-3786-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1932,x:29977,y:32250,ptovrint:False,ptlb:Effect Tile Amount,ptin:_EffectTileAmount,varname:_EffectTileAmount,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:483,x:33194,y:32535,varname:node_483,prsc:2|A-1080-RGB,B-8442-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8442,x:33005,y:32558,ptovrint:False,ptlb:Emission Amount,ptin:_EmissionAmount,varname:node_8442,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Fresnel,id:1262,x:31527,y:32847,varname:node_1262,prsc:2|EXP-1620-OUT;n:type:ShaderForge.SFN_Vector1,id:1620,x:31352,y:32881,varname:node_1620,prsc:2,v1:3;n:type:ShaderForge.SFN_Clamp01,id:3413,x:31699,y:32847,varname:node_3413,prsc:2|IN-1262-OUT;n:type:ShaderForge.SFN_Blend,id:7499,x:31966,y:32632,varname:node_7499,prsc:2,blmd:7,clmp:True|SRC-775-OUT,DST-3413-OUT;n:type:ShaderForge.SFN_Multiply,id:4189,x:33039,y:32759,varname:node_4189,prsc:2|A-1661-OUT,B-8928-OUT;n:type:ShaderForge.SFN_Vector1,id:8928,x:32857,y:32922,varname:node_8928,prsc:2,v1:0.0005;n:type:ShaderForge.SFN_OneMinus,id:1218,x:32695,y:32759,varname:node_1218,prsc:2|IN-775-OUT;n:type:ShaderForge.SFN_Multiply,id:9128,x:33074,y:33053,varname:node_9128,prsc:2|A-9252-OUT,B-113-OUT;n:type:ShaderForge.SFN_ValueProperty,id:113,x:32867,y:33226,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_113,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_RemapRange,id:1661,x:32857,y:32759,varname:node_1661,prsc:2,frmn:0,frmx:1,tomn:-5,tomx:1|IN-1218-OUT;proporder:7372-1932-2500-9983-5705-6518-1080-8442-113;pass:END;sub:END;*/

Shader "Shader Forge/Test3" {
    Properties {
        _CloudTexture ("Cloud Texture", 2D) = "white" {}
        _EffectTileAmount ("Effect Tile Amount", Float ) = 1
        _Shield_Top ("Shield_Top", Float ) = 1
        _Shield_Left ("Shield_Left", Float ) = 1
        _Shield_Right ("Shield_Right", Float ) = 1
        _Shield_Bottom ("Shield_Bottom", Float ) = 1
        _Colour ("Colour", Color) = (0.5,0.5,0.5,1)
        _EmissionAmount ("Emission Amount", Float ) = 0
        _Opacity ("Opacity", Float ) = 0.5
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
            uniform float _EffectTileAmount;
            uniform float _EmissionAmount;
            uniform float _Opacity;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(3)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_754 = _Time;
                float2 node_475 = frac((o.uv0*_EffectTileAmount));
                float2 node_2925 = (node_475+node_754.g*float2(0.03,0.1));
                float4 node_5117 = tex2Dlod(_CloudTexture,float4(TRANSFORM_TEX(node_2925, _CloudTexture),0.0,0));
                float node_9_ang = node_754.g;
                float node_9_spd = 0.1;
                float node_9_cos = cos(node_9_spd*node_9_ang);
                float node_9_sin = sin(node_9_spd*node_9_ang);
                float2 node_9_piv = float2(0.5,0.5);
                float2 node_9 = (mul(node_475-node_9_piv,float2x2( node_9_cos, -node_9_sin, node_9_sin, node_9_cos))+node_9_piv);
                float2 node_8332 = (node_9+node_754.g*float2(-0.01,0.02));
                float4 _node_7358_copy = tex2Dlod(_CloudTexture,float4(TRANSFORM_TEX(node_8332, _CloudTexture),0.0,0));
                float node_775 = saturate(abs(node_5117.r-_node_7358_copy.r));
                float node_4189 = (((1.0 - node_775)*6.0+-5.0)*0.0005);
                v.vertex.xyz += float3(node_4189,node_4189,node_4189);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
////// Lighting:
////// Emissive:
                float3 emissive = (_Colour.rgb*_EmissionAmount);
                float3 finalColor = emissive;
                float node_3413 = saturate(pow(1.0-max(0,dot(normalDirection, viewDirection)),3.0));
                float4 node_696 = float4((i.vertexColor.r*saturate(_Shield_Top)),(i.vertexColor.g*saturate(_Shield_Right)),(i.vertexColor.b*saturate(_Shield_Left)),(i.vertexColor.a*saturate(_Shield_Bottom)));
                float node_8501 = 1.0;
                fixed4 finalRGBA = fixed4(finalColor,(saturate((node_3413*(node_696.r*node_8501 + node_696.g*node_8501 + node_696.b*node_8501 + node_696.a*node_8501)))*_Opacity));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Back
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _CloudTexture; uniform float4 _CloudTexture_ST;
            uniform float _EffectTileAmount;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 node_8521 = _Time;
                float2 node_475 = frac((o.uv0*_EffectTileAmount));
                float2 node_2925 = (node_475+node_8521.g*float2(0.03,0.1));
                float4 node_5117 = tex2Dlod(_CloudTexture,float4(TRANSFORM_TEX(node_2925, _CloudTexture),0.0,0));
                float node_9_ang = node_8521.g;
                float node_9_spd = 0.1;
                float node_9_cos = cos(node_9_spd*node_9_ang);
                float node_9_sin = sin(node_9_spd*node_9_ang);
                float2 node_9_piv = float2(0.5,0.5);
                float2 node_9 = (mul(node_475-node_9_piv,float2x2( node_9_cos, -node_9_sin, node_9_sin, node_9_cos))+node_9_piv);
                float2 node_8332 = (node_9+node_8521.g*float2(-0.01,0.02));
                float4 _node_7358_copy = tex2Dlod(_CloudTexture,float4(TRANSFORM_TEX(node_8332, _CloudTexture),0.0,0));
                float node_775 = saturate(abs(node_5117.r-_node_7358_copy.r));
                float node_4189 = (((1.0 - node_775)*6.0+-5.0)*0.0005);
                v.vertex.xyz += float3(node_4189,node_4189,node_4189);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                SHADOW_CASTER_FRAGMENT(i)
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
            uniform sampler2D _CloudTexture; uniform float4 _CloudTexture_ST;
            uniform float4 _Colour;
            uniform float _EffectTileAmount;
            uniform float _EmissionAmount;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 node_5178 = _Time;
                float2 node_475 = frac((o.uv0*_EffectTileAmount));
                float2 node_2925 = (node_475+node_5178.g*float2(0.03,0.1));
                float4 node_5117 = tex2Dlod(_CloudTexture,float4(TRANSFORM_TEX(node_2925, _CloudTexture),0.0,0));
                float node_9_ang = node_5178.g;
                float node_9_spd = 0.1;
                float node_9_cos = cos(node_9_spd*node_9_ang);
                float node_9_sin = sin(node_9_spd*node_9_ang);
                float2 node_9_piv = float2(0.5,0.5);
                float2 node_9 = (mul(node_475-node_9_piv,float2x2( node_9_cos, -node_9_sin, node_9_sin, node_9_cos))+node_9_piv);
                float2 node_8332 = (node_9+node_5178.g*float2(-0.01,0.02));
                float4 _node_7358_copy = tex2Dlod(_CloudTexture,float4(TRANSFORM_TEX(node_8332, _CloudTexture),0.0,0));
                float node_775 = saturate(abs(node_5117.r-_node_7358_copy.r));
                float node_4189 = (((1.0 - node_775)*6.0+-5.0)*0.0005);
                v.vertex.xyz += float3(node_4189,node_4189,node_4189);
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
