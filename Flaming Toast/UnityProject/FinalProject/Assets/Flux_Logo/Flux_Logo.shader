// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:34642,y:32465,cmnt:this shader was mostly a result of fucking around,varname:node_3138,prsc:2|emission-8972-OUT,clip-7041-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:32536,y:32472,ptovrint:False,ptlb:fluid colour,ptin:_fluidcolour,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.3897059,c2:1,c3:0.8484788,c4:1;n:type:ShaderForge.SFN_Tex2d,id:9719,x:31279,y:32683,cmnt:wave detail,varname:node_9719,prsc:2,tex:aeaa2c3b3fe5f534eb98ea9fcc3a12b5,ntxv:0,isnm:False|UVIN-7985-UVOUT,TEX-5657-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:5657,x:30864,y:32791,ptovrint:False,ptlb:texture,ptin:_texture,varname:node_5657,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:aeaa2c3b3fe5f534eb98ea9fcc3a12b5,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:7797,x:31279,y:32535,cmnt:wave AKA liquid,varname:node_7797,prsc:2,tex:aeaa2c3b3fe5f534eb98ea9fcc3a12b5,ntxv:0,isnm:False|UVIN-5719-UVOUT,TEX-5657-TEX;n:type:ShaderForge.SFN_Panner,id:5719,x:30864,y:32424,cmnt:all panners just for adding movement,varname:node_5719,prsc:2,spu:0.1,spv:0|UVIN-8297-UVOUT;n:type:ShaderForge.SFN_Panner,id:7985,x:30864,y:32592,varname:node_7985,prsc:2,spu:-0.1,spv:0|UVIN-8297-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:8297,x:30099,y:32736,varname:node_8297,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Tex2d,id:434,x:31279,y:32382,cmnt:flux mask,varname:node_434,prsc:2,tex:aeaa2c3b3fe5f534eb98ea9fcc3a12b5,ntxv:0,isnm:False|TEX-5657-TEX;n:type:ShaderForge.SFN_Blend,id:2539,x:31545,y:32615,cmnt:wave blending,varname:node_2539,prsc:2,blmd:12,clmp:True|SRC-7797-B,DST-9719-G;n:type:ShaderForge.SFN_Multiply,id:6275,x:33003,y:32471,cmnt:liquid colour,varname:node_6275,prsc:2|A-7241-RGB,B-1464-OUT;n:type:ShaderForge.SFN_Color,id:424,x:32536,y:32303,ptovrint:False,ptlb:background colour,ptin:_backgroundcolour,varname:node_424,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4632353,c2:0.4632353,c3:0.4632353,c4:1;n:type:ShaderForge.SFN_OneMinus,id:1464,x:32692,y:32701,cmnt:inverting it for liquid and top of liquid,varname:node_1464,prsc:2|IN-4540-OUT;n:type:ShaderForge.SFN_Clamp01,id:4540,x:32488,y:32669,varname:node_4540,prsc:2|IN-7978-OUT;n:type:ShaderForge.SFN_RemapRange,id:7978,x:32046,y:32680,cmnt:clearing any artifacts,varname:node_7978,prsc:2,frmn:0,frmx:1,tomn:0,tomx:1.3|IN-9487-OUT;n:type:ShaderForge.SFN_Multiply,id:8357,x:33003,y:32301,cmnt:background colour,varname:node_8357,prsc:2|A-424-RGB,B-4540-OUT;n:type:ShaderForge.SFN_Add,id:9923,x:33772,y:32703,cmnt:adding it all together,varname:node_9923,prsc:2|A-1988-OUT,B-3429-OUT,C-2786-OUT,D-6090-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6343,x:33971,y:32625,ptovrint:False,ptlb:brightness,ptin:_brightness,varname:node_6343,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Tex2d,id:7945,x:31596,y:33030,cmnt:bubbles,varname:node_7945,prsc:2,tex:aeaa2c3b3fe5f534eb98ea9fcc3a12b5,ntxv:0,isnm:False|UVIN-2207-UVOUT,TEX-5657-TEX;n:type:ShaderForge.SFN_Panner,id:2207,x:30864,y:32999,varname:node_2207,prsc:2,spu:0,spv:-0.15|UVIN-8297-UVOUT;n:type:ShaderForge.SFN_Blend,id:3773,x:32289,y:32819,cmnt:masking the bubbles,varname:node_3773,prsc:2,blmd:19,clmp:True|SRC-7978-OUT,DST-522-OUT;n:type:ShaderForge.SFN_Clamp01,id:4103,x:33971,y:32703,varname:node_4103,prsc:2|IN-9923-OUT;n:type:ShaderForge.SFN_RemapRange,id:3349,x:31419,y:32830,cmnt:creating gradient for bubble fade in,varname:node_3349,prsc:2,frmn:0,frmx:1,tomn:-1.5,tomx:3|IN-8297-V;n:type:ShaderForge.SFN_Multiply,id:5475,x:31886,y:32938,cmnt:applying a fade in,varname:node_5475,prsc:2|A-3032-OUT,B-7945-A;n:type:ShaderForge.SFN_Multiply,id:9913,x:34163,y:32608,varname:node_9913,prsc:2|A-6343-OUT,B-4103-OUT;n:type:ShaderForge.SFN_Get,id:7041,x:34402,y:32785,cmnt:see flux mask,varname:node_7041,prsc:2|IN-7941-OUT;n:type:ShaderForge.SFN_Set,id:7941,x:31461,y:32418,cmnt:see opacity clip input,varname:mask,prsc:2|IN-434-R;n:type:ShaderForge.SFN_Multiply,id:5853,x:32765,y:33016,cmnt:bubble colour,varname:node_5853,prsc:2|A-7978-OUT,B-60-RGB;n:type:ShaderForge.SFN_Color,id:60,x:32455,y:32995,ptovrint:False,ptlb:highlight colour,ptin:_highlightcolour,varname:node_60,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.8758622,c3:1,c4:1;n:type:ShaderForge.SFN_Blend,id:5437,x:32988,y:32988,cmnt:getting the top isolated by using an inverted version of the same thing so that the two blacks mask out each other except for the center,varname:node_5437,prsc:2,blmd:1,clmp:True|SRC-1464-OUT,DST-5853-OUT;n:type:ShaderForge.SFN_Multiply,id:522,x:32075,y:32938,varname:node_522,prsc:2|A-5475-OUT,B-3670-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3670,x:31886,y:33110,ptovrint:False,ptlb:bubble opacity,ptin:_bubbleopacity,varname:node_3670,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.3;n:type:ShaderForge.SFN_RemapRange,id:2786,x:33206,y:33024,cmnt:making it brighter,varname:node_2786,prsc:2,frmn:0,frmx:1,tomn:0,tomx:2|IN-5437-OUT;n:type:ShaderForge.SFN_Blend,id:9487,x:31815,y:32637,cmnt:idk seems to add more gradient to the top,varname:node_9487,prsc:2,blmd:3,clmp:True|SRC-2539-OUT,DST-3032-OUT;n:type:ShaderForge.SFN_Blend,id:8972,x:34378,y:32525,cmnt:adding liquid gradient,varname:node_8972,prsc:2,blmd:1,clmp:True|SRC-9913-OUT,DST-2032-OUT;n:type:ShaderForge.SFN_RemapRange,id:2032,x:31449,y:32171,cmnt:creating gradient for darker part of the liquid,varname:node_2032,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:3|IN-8297-V;n:type:ShaderForge.SFN_Multiply,id:6090,x:33271,y:32772,cmnt:adding colour to the bubbles,varname:node_6090,prsc:2|A-60-RGB,B-3773-OUT;n:type:ShaderForge.SFN_Clamp01,id:3032,x:31604,y:32830,varname:node_3032,prsc:2|IN-3349-OUT;n:type:ShaderForge.SFN_RemapRange,id:6125,x:31449,y:31987,cmnt:creating gradient for darker part of the background,varname:node_6125,prsc:2,frmn:0,frmx:1,tomn:-1.8,tomx:2.2|IN-8297-V;n:type:ShaderForge.SFN_Blend,id:1988,x:33296,y:32341,varname:node_1988,prsc:2,blmd:1,clmp:True|SRC-8357-OUT,DST-6125-OUT;n:type:ShaderForge.SFN_Blend,id:3429,x:33286,y:32556,varname:node_3429,prsc:2,blmd:1,clmp:True|SRC-6275-OUT,DST-2032-OUT;proporder:5657-424-7241-60-6343-3670;pass:END;sub:END;*/

Shader "Shader Forge/Flux_Logo" {
    Properties {
        _texture ("texture", 2D) = "white" {}
        _backgroundcolour ("background colour", Color) = (0.4632353,0.4632353,0.4632353,1)
        _fluidcolour ("fluid colour", Color) = (0.3897059,1,0.8484788,1)
        _highlightcolour ("highlight colour", Color) = (0,0.8758622,1,1)
        _brightness ("brightness", Float ) = 1
        _bubbleopacity ("bubble opacity", Float ) = 0.3
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
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
            uniform float4 _fluidcolour;
            uniform sampler2D _texture; uniform float4 _texture_ST;
            uniform float4 _backgroundcolour;
            uniform float _brightness;
            uniform float4 _highlightcolour;
            uniform float _bubbleopacity;
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
                float4 node_434 = tex2D(_texture,TRANSFORM_TEX(i.uv0, _texture)); // flux mask
                float mask = node_434.r; // see opacity clip input
                clip(mask - 0.5);
////// Lighting:
////// Emissive:
                float4 node_5898 = _Time;
                float2 node_5719 = (i.uv0+node_5898.g*float2(0.1,0)); // all panners just for adding movement
                float4 node_7797 = tex2D(_texture,TRANSFORM_TEX(node_5719, _texture)); // wave AKA liquid
                float2 node_7985 = (i.uv0+node_5898.g*float2(-0.1,0));
                float4 node_9719 = tex2D(_texture,TRANSFORM_TEX(node_7985, _texture)); // wave detail
                float node_3032 = saturate((i.uv0.g*4.5+-1.5));
                float node_7978 = (saturate((saturate((node_7797.b > 0.5 ?  (1.0-(1.0-2.0*(node_7797.b-0.5))*(1.0-node_9719.g)) : (2.0*node_7797.b*node_9719.g)) )+node_3032-1.0))*1.3+0.0); // clearing any artifacts
                float node_4540 = saturate(node_7978);
                float node_1464 = (1.0 - node_4540); // inverting it for liquid and top of liquid
                float node_2032 = (i.uv0.g*4.0+-1.0); // creating gradient for darker part of the liquid
                float2 node_2207 = (i.uv0+node_5898.g*float2(0,-0.15));
                float4 node_7945 = tex2D(_texture,TRANSFORM_TEX(node_2207, _texture)); // bubbles
                float3 emissive = saturate(((_brightness*saturate((saturate(((_backgroundcolour.rgb*node_4540)*(i.uv0.g*4.0+-1.8)))+saturate(((_fluidcolour.rgb*node_1464)*node_2032))+(saturate((node_1464*(node_7978*_highlightcolour.rgb)))*2.0+0.0)+(_highlightcolour.rgb*saturate((((node_3032*node_7945.a)*_bubbleopacity)-node_7978))))))*node_2032));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
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
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _texture; uniform float4 _texture_ST;
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
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 node_434 = tex2D(_texture,TRANSFORM_TEX(i.uv0, _texture)); // flux mask
                float mask = node_434.r; // see opacity clip input
                clip(mask - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
