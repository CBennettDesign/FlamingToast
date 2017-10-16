// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:0,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:3,bdst:0,dpts:6,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:False,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:33823,y:32918,varname:node_2865,prsc:2|diff-1080-RGB,diffpow-2996-OUT,spec-2996-OUT,gloss-2996-OUT,alpha-2203-OUT;n:type:ShaderForge.SFN_TexCoord,id:2073,x:29834,y:32083,varname:node_2073,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:2925,x:30726,y:32063,varname:node_2925,prsc:2,spu:0.03,spv:0.1|UVIN-475-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:7372,x:30726,y:32442,ptovrint:False,ptlb:Cloud Texture,ptin:_CloudTexture,varname:node_3958,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:3630,x:30918,y:32063,varname:node_5117,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-2925-UVOUT,TEX-7372-TEX;n:type:ShaderForge.SFN_Panner,id:8332,x:30726,y:32233,varname:node_8332,prsc:2,spu:-0.01,spv:0.02|UVIN-9-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:7368,x:30918,y:32233,varname:_node_7358_copy,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-8332-UVOUT,TEX-7372-TEX;n:type:ShaderForge.SFN_Blend,id:775,x:31174,y:32141,varname:node_775,prsc:2,blmd:17,clmp:True|SRC-3630-R,DST-7368-R;n:type:ShaderForge.SFN_Rotator,id:9,x:30528,y:32243,varname:node_9,prsc:2|UVIN-475-OUT,SPD-7389-OUT;n:type:ShaderForge.SFN_Vector1,id:7389,x:30321,y:32371,varname:node_7389,prsc:2,v1:0.1;n:type:ShaderForge.SFN_VertexColor,id:7873,x:30440,y:32970,varname:node_7873,prsc:2;n:type:ShaderForge.SFN_ChannelBlend,id:9268,x:31717,y:33345,varname:node_9268,prsc:2,chbt:0|M-696-OUT,R-8501-OUT,G-8501-OUT,B-8501-OUT,A-8501-OUT;n:type:ShaderForge.SFN_Append,id:696,x:31495,y:33250,varname:node_696,prsc:2|A-4968-OUT,B-8247-OUT,C-8663-OUT,D-2242-OUT;n:type:ShaderForge.SFN_Multiply,id:4968,x:31292,y:33099,varname:node_4968,prsc:2|A-704-OUT,B-6897-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6518,x:30782,y:33137,ptovrint:False,ptlb:Shield_1,ptin:_Shield_1,varname:node_2333,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:9983,x:30782,y:33278,ptovrint:False,ptlb:Shield_2,ptin:_Shield_2,varname:_Shield_2,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:5705,x:30782,y:33426,ptovrint:False,ptlb:Shield_3,ptin:_Shield_3,varname:_Shield_3,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:2500,x:30782,y:33575,ptovrint:False,ptlb:Shield_4,ptin:_Shield_4,varname:_Shield_4,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:8247,x:31276,y:33227,varname:node_8247,prsc:2|A-7873-G,B-159-OUT;n:type:ShaderForge.SFN_Multiply,id:8663,x:31276,y:33365,varname:node_8663,prsc:2|A-7873-B,B-9930-OUT;n:type:ShaderForge.SFN_Multiply,id:2242,x:31276,y:33506,varname:node_2242,prsc:2|A-7873-A,B-9305-OUT;n:type:ShaderForge.SFN_Clamp01,id:6897,x:30959,y:33103,varname:node_6897,prsc:2|IN-6518-OUT;n:type:ShaderForge.SFN_Clamp01,id:159,x:30959,y:33254,varname:node_159,prsc:2|IN-9983-OUT;n:type:ShaderForge.SFN_Clamp01,id:9930,x:30959,y:33392,varname:node_9930,prsc:2|IN-5705-OUT;n:type:ShaderForge.SFN_Clamp01,id:9305,x:30959,y:33541,varname:node_9305,prsc:2|IN-2500-OUT;n:type:ShaderForge.SFN_Vector1,id:8501,x:31495,y:33389,varname:node_8501,prsc:2,v1:1;n:type:ShaderForge.SFN_Blend,id:9252,x:32166,y:33033,varname:node_9252,prsc:2,blmd:19,clmp:True|SRC-775-OUT,DST-9268-OUT;n:type:ShaderForge.SFN_Color,id:1080,x:33165,y:32764,ptovrint:False,ptlb:Colour,ptin:_Colour,varname:node_1080,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Relay,id:3242,x:31077,y:32897,cmnt:Directions of the shield using vertex painting,varname:node_3242,prsc:2;n:type:ShaderForge.SFN_Relay,id:3742,x:30819,y:31960,cmnt:Cloudy effect,varname:node_3742,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:5253,x:31931,y:33644,ptovrint:False,ptlb:Pattern Tile Texture,ptin:_PatternTileTexture,varname:node_5253,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-7193-OUT;n:type:ShaderForge.SFN_Blend,id:9625,x:32716,y:33170,varname:node_9625,prsc:2,blmd:3,clmp:True|SRC-9252-OUT,DST-2907-OUT;n:type:ShaderForge.SFN_OneMinus,id:272,x:32142,y:33696,varname:node_272,prsc:2|IN-5253-R;n:type:ShaderForge.SFN_TexCoord,id:7496,x:31397,y:33661,varname:node_7496,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:5807,x:31558,y:33661,varname:node_5807,prsc:2|A-7496-UVOUT,B-2353-OUT;n:type:ShaderForge.SFN_Frac,id:7193,x:31714,y:33661,varname:node_7193,prsc:2|IN-5807-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2353,x:31397,y:33834,ptovrint:False,ptlb:Pattern Tile Amount,ptin:_PatternTileAmount,varname:node_2353,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-1;n:type:ShaderForge.SFN_SwitchProperty,id:2907,x:32396,y:33590,ptovrint:False,ptlb:Invert?,ptin:_Invert,varname:node_2907,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-5253-R,B-272-OUT;n:type:ShaderForge.SFN_Vector1,id:2996,x:33165,y:32922,varname:node_2996,prsc:2,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:9641,x:32634,y:33439,ptovrint:False,ptlb:Overall Transparency,ptin:_OverallTransparency,varname:node_9641,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:261,x:33000,y:33253,varname:node_261,prsc:2|A-9625-OUT,B-9641-OUT;n:type:ShaderForge.SFN_Multiply,id:3786,x:30088,y:32083,varname:node_3786,prsc:2|A-2073-UVOUT,B-1932-OUT;n:type:ShaderForge.SFN_Frac,id:475,x:30253,y:32083,varname:node_475,prsc:2|IN-3786-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1932,x:29834,y:32253,ptovrint:False,ptlb:Effect Tile Amount,ptin:_EffectTileAmount,varname:_PatternTileAmount_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Clamp01,id:2203,x:33666,y:33173,varname:node_2203,prsc:2|IN-5033-OUT;n:type:ShaderForge.SFN_Tex2d,id:1282,x:32868,y:34054,ptovrint:False,ptlb:mask,ptin:_mask,varname:node_1282,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-2381-UVOUT;n:type:ShaderForge.SFN_Multiply,id:496,x:33262,y:33418,varname:node_496,prsc:2|A-5624-OUT,B-3520-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5624,x:33044,y:33418,ptovrint:False,ptlb:mask multiplyer,ptin:_maskmultiplyer,varname:node_5624,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_TexCoord,id:2639,x:32474,y:34107,varname:node_2639,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Rotator,id:2381,x:32679,y:34107,varname:node_2381,prsc:2|UVIN-2639-UVOUT,ANG-108-OUT;n:type:ShaderForge.SFN_ValueProperty,id:108,x:32474,y:34291,ptovrint:False,ptlb:mask rotation,ptin:_maskrotation,varname:node_108,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Subtract,id:5033,x:33262,y:33252,varname:node_5033,prsc:2|A-261-OUT,B-496-OUT;n:type:ShaderForge.SFN_RemapRange,id:8058,x:33115,y:34032,varname:node_8058,prsc:2,frmn:0,frmx:1,tomn:-0.1,tomx:1|IN-1282-R;n:type:ShaderForge.SFN_Clamp01,id:3520,x:33279,y:34012,varname:node_3520,prsc:2|IN-8058-OUT;n:type:ShaderForge.SFN_Get,id:704,x:31077,y:33064,varname:node_704,prsc:2|IN-9284-OUT;n:type:ShaderForge.SFN_Set,id:9284,x:30663,y:32957,varname:red,prsc:2|IN-7873-R;proporder:7372-1932-6518-9983-5705-2500-9641-1080-5253-2353-2907-1282-5624-108;pass:END;sub:END;*/

Shader "Shader Forge/Test3" {
    Properties {
        _CloudTexture ("Cloud Texture", 2D) = "white" {}
        _EffectTileAmount ("Effect Tile Amount", Float ) = 1
        _Shield_1 ("Shield_1", Float ) = 0
        _Shield_2 ("Shield_2", Float ) = 0
        _Shield_3 ("Shield_3", Float ) = 0
        _Shield_4 ("Shield_4", Float ) = 0
        _OverallTransparency ("Overall Transparency", Float ) = 0
        _Colour ("Colour", Color) = (0.5,0.5,0.5,1)
        _PatternTileTexture ("Pattern Tile Texture", 2D) = "white" {}
        _PatternTileAmount ("Pattern Tile Amount", Float ) = -1
        [MaterialToggle] _Invert ("Invert?", Float ) = 0
        _mask ("mask", 2D) = "white" {}
        _maskmultiplyer ("mask multiplyer", Float ) = 0
        _maskrotation ("mask rotation", Float ) = 0
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
            Cull Off
            ZTest Always
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _CloudTexture; uniform float4 _CloudTexture_ST;
            uniform float _Shield_1;
            uniform float _Shield_2;
            uniform float _Shield_3;
            uniform float _Shield_4;
            uniform float4 _Colour;
            uniform sampler2D _PatternTileTexture; uniform float4 _PatternTileTexture_ST;
            uniform float _PatternTileAmount;
            uniform fixed _Invert;
            uniform float _OverallTransparency;
            uniform float _EffectTileAmount;
            uniform sampler2D _mask; uniform float4 _mask_ST;
            uniform float _maskmultiplyer;
            uniform float _maskrotation;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(7)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD8;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.vertexColor = v.vertexColor;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #elif UNITY_SHOULD_SAMPLE_SH
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float node_2996 = 0.0;
                float gloss = node_2996;
                float perceptualRoughness = 1.0 - node_2996;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                #if UNITY_SPECCUBE_BLENDING || UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMin[0] = unity_SpecCube0_BoxMin;
                    d.boxMin[1] = unity_SpecCube1_BoxMin;
                #endif
                #if UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMax[0] = unity_SpecCube0_BoxMax;
                    d.boxMax[1] = unity_SpecCube1_BoxMax;
                    d.probePosition[0] = unity_SpecCube0_ProbePosition;
                    d.probePosition[1] = unity_SpecCube1_ProbePosition;
                #endif
                d.probeHDR[0] = unity_SpecCube0_HDR;
                d.probeHDR[1] = unity_SpecCube1_HDR;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = float3(node_2996,node_2996,node_2996);
                float specularMonochrome;
                float3 diffuseColor = _Colour.rgb; // Need this for specular when using metallic
                diffuseColor = EnergyConservationBetweenDiffuseAndSpecular(diffuseColor, specularColor, specularMonochrome);
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                half surfaceReduction;
                #ifdef UNITY_COLORSPACE_GAMMA
                    surfaceReduction = 1.0-0.28*roughness*perceptualRoughness;
                #else
                    surfaceReduction = 1.0/(roughness*roughness + 1.0);
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (gi.indirect.specular);
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                indirectSpecular *= surfaceReduction;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float4 node_8278 = _Time;
                float2 node_475 = frac((i.uv0*_EffectTileAmount));
                float2 node_2925 = (node_475+node_8278.g*float2(0.03,0.1));
                float4 node_5117 = tex2D(_CloudTexture,TRANSFORM_TEX(node_2925, _CloudTexture));
                float node_9_ang = node_8278.g;
                float node_9_spd = 0.1;
                float node_9_cos = cos(node_9_spd*node_9_ang);
                float node_9_sin = sin(node_9_spd*node_9_ang);
                float2 node_9_piv = float2(0.5,0.5);
                float2 node_9 = (mul(node_475-node_9_piv,float2x2( node_9_cos, -node_9_sin, node_9_sin, node_9_cos))+node_9_piv);
                float2 node_8332 = (node_9+node_8278.g*float2(-0.01,0.02));
                float4 _node_7358_copy = tex2D(_CloudTexture,TRANSFORM_TEX(node_8332, _CloudTexture));
                float red = i.vertexColor.r;
                float4 node_696 = float4((red*saturate(_Shield_1)),(i.vertexColor.g*saturate(_Shield_2)),(i.vertexColor.b*saturate(_Shield_3)),(i.vertexColor.a*saturate(_Shield_4)));
                float node_8501 = 1.0;
                float node_9252 = saturate(((node_696.r*node_8501 + node_696.g*node_8501 + node_696.b*node_8501 + node_696.a*node_8501)-saturate(abs(node_5117.r-_node_7358_copy.r))));
                float2 node_7193 = frac((i.uv0*_PatternTileAmount));
                float4 _PatternTileTexture_var = tex2D(_PatternTileTexture,TRANSFORM_TEX(node_7193, _PatternTileTexture));
                float node_2381_ang = _maskrotation;
                float node_2381_spd = 1.0;
                float node_2381_cos = cos(node_2381_spd*node_2381_ang);
                float node_2381_sin = sin(node_2381_spd*node_2381_ang);
                float2 node_2381_piv = float2(0.5,0.5);
                float2 node_2381 = (mul(i.uv0-node_2381_piv,float2x2( node_2381_cos, -node_2381_sin, node_2381_sin, node_2381_cos))+node_2381_piv);
                float4 _mask_var = tex2D(_mask,TRANSFORM_TEX(node_2381, _mask));
                fixed4 finalRGBA = fixed4(finalColor,saturate(((saturate((node_9252+lerp( _PatternTileTexture_var.r, (1.0 - _PatternTileTexture_var.r), _Invert )-1.0))*_OverallTransparency)-(_maskmultiplyer*saturate((_mask_var.r*1.1+-0.1))))));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            Cull Off
            ZTest Always
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _CloudTexture; uniform float4 _CloudTexture_ST;
            uniform float _Shield_1;
            uniform float _Shield_2;
            uniform float _Shield_3;
            uniform float _Shield_4;
            uniform float4 _Colour;
            uniform sampler2D _PatternTileTexture; uniform float4 _PatternTileTexture_ST;
            uniform float _PatternTileAmount;
            uniform fixed _Invert;
            uniform float _OverallTransparency;
            uniform float _EffectTileAmount;
            uniform sampler2D _mask; uniform float4 _mask_ST;
            uniform float _maskmultiplyer;
            uniform float _maskrotation;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 vertexColor : COLOR;
                LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float node_2996 = 0.0;
                float gloss = node_2996;
                float perceptualRoughness = 1.0 - node_2996;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = float3(node_2996,node_2996,node_2996);
                float specularMonochrome;
                float3 diffuseColor = _Colour.rgb; // Need this for specular when using metallic
                diffuseColor = EnergyConservationBetweenDiffuseAndSpecular(diffuseColor, specularColor, specularMonochrome);
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float4 node_3398 = _Time;
                float2 node_475 = frac((i.uv0*_EffectTileAmount));
                float2 node_2925 = (node_475+node_3398.g*float2(0.03,0.1));
                float4 node_5117 = tex2D(_CloudTexture,TRANSFORM_TEX(node_2925, _CloudTexture));
                float node_9_ang = node_3398.g;
                float node_9_spd = 0.1;
                float node_9_cos = cos(node_9_spd*node_9_ang);
                float node_9_sin = sin(node_9_spd*node_9_ang);
                float2 node_9_piv = float2(0.5,0.5);
                float2 node_9 = (mul(node_475-node_9_piv,float2x2( node_9_cos, -node_9_sin, node_9_sin, node_9_cos))+node_9_piv);
                float2 node_8332 = (node_9+node_3398.g*float2(-0.01,0.02));
                float4 _node_7358_copy = tex2D(_CloudTexture,TRANSFORM_TEX(node_8332, _CloudTexture));
                float red = i.vertexColor.r;
                float4 node_696 = float4((red*saturate(_Shield_1)),(i.vertexColor.g*saturate(_Shield_2)),(i.vertexColor.b*saturate(_Shield_3)),(i.vertexColor.a*saturate(_Shield_4)));
                float node_8501 = 1.0;
                float node_9252 = saturate(((node_696.r*node_8501 + node_696.g*node_8501 + node_696.b*node_8501 + node_696.a*node_8501)-saturate(abs(node_5117.r-_node_7358_copy.r))));
                float2 node_7193 = frac((i.uv0*_PatternTileAmount));
                float4 _PatternTileTexture_var = tex2D(_PatternTileTexture,TRANSFORM_TEX(node_7193, _PatternTileTexture));
                float node_2381_ang = _maskrotation;
                float node_2381_spd = 1.0;
                float node_2381_cos = cos(node_2381_spd*node_2381_ang);
                float node_2381_sin = sin(node_2381_spd*node_2381_ang);
                float2 node_2381_piv = float2(0.5,0.5);
                float2 node_2381 = (mul(i.uv0-node_2381_piv,float2x2( node_2381_cos, -node_2381_sin, node_2381_sin, node_2381_cos))+node_2381_piv);
                float4 _mask_var = tex2D(_mask,TRANSFORM_TEX(node_2381, _mask));
                fixed4 finalRGBA = fixed4(finalColor * saturate(((saturate((node_9252+lerp( _PatternTileTexture_var.r, (1.0 - _PatternTileTexture_var.r), _Invert )-1.0))*_OverallTransparency)-(_maskmultiplyer*saturate((_mask_var.r*1.1+-0.1))))),0);
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
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
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
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _Colour;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv1 : TEXCOORD0;
                float2 uv2 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : SV_Target {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                o.Emission = 0;
                
                float3 diffColor = _Colour.rgb;
                float node_2996 = 0.0;
                float3 specColor = float3(node_2996,node_2996,node_2996);
                float specularMonochrome = max(max(specColor.r, specColor.g),specColor.b);
                diffColor *= (1.0-specularMonochrome);
                float roughness = 1.0 - node_2996;
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
