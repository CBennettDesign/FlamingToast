// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:1,cusa:True,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:True,tesm:0,olmd:1,culm:2,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:True,atwp:True,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:1873,x:33671,y:32957,varname:node_1873,prsc:2|emission-1435-OUT,alpha-3619-OUT;n:type:ShaderForge.SFN_Tex2d,id:1807,x:32377,y:32822,varname:node_1807,prsc:2,tex:713b5a60793378d46b4ccf40490ac2bc,ntxv:0,isnm:False|UVIN-903-UVOUT,TEX-186-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:186,x:32145,y:33366,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_186,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:713b5a60793378d46b4ccf40490ac2bc,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:7208,x:32377,y:33153,varname:_node_123_copy,prsc:2,tex:713b5a60793378d46b4ccf40490ac2bc,ntxv:0,isnm:False|UVIN-630-UVOUT,TEX-186-TEX;n:type:ShaderForge.SFN_TexCoord,id:1991,x:31113,y:32854,varname:node_1991,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:903,x:32073,y:32821,varname:node_903,prsc:2,spu:0,spv:0|UVIN-1991-UVOUT,DIST-5382-OUT;n:type:ShaderForge.SFN_Panner,id:239,x:32073,y:32981,varname:node_239,prsc:2,spu:0.05,spv:0|UVIN-1991-UVOUT,DIST-5382-OUT;n:type:ShaderForge.SFN_Panner,id:630,x:32073,y:33154,varname:node_630,prsc:2,spu:-0.05,spv:0|UVIN-1991-UVOUT,DIST-5382-OUT;n:type:ShaderForge.SFN_Slider,id:5382,x:31483,y:33159,ptovrint:False,ptlb:RGB,ptin:_RGB,varname:node_5382,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Append,id:7313,x:32825,y:32943,varname:node_7313,prsc:2|A-1807-R,B-6883-G,C-7208-B;n:type:ShaderForge.SFN_Add,id:1606,x:32825,y:33110,varname:node_1606,prsc:2|A-3806-OUT,B-5211-OUT,C-5523-OUT;n:type:ShaderForge.SFN_Clamp01,id:7558,x:33008,y:33110,varname:node_7558,prsc:2|IN-1606-OUT;n:type:ShaderForge.SFN_Tex2d,id:6883,x:32379,y:32967,varname:node_6883,prsc:2,tex:713b5a60793378d46b4ccf40490ac2bc,ntxv:0,isnm:False|UVIN-239-UVOUT,TEX-186-TEX;n:type:ShaderForge.SFN_Multiply,id:5523,x:32585,y:33244,varname:node_5523,prsc:2|A-7208-B,B-953-OUT;n:type:ShaderForge.SFN_Multiply,id:3806,x:32594,y:32889,varname:node_3806,prsc:2|A-1807-R,B-953-OUT;n:type:ShaderForge.SFN_Multiply,id:5211,x:32594,y:33037,varname:node_5211,prsc:2|A-6883-G,B-953-OUT;n:type:ShaderForge.SFN_Vector1,id:953,x:32397,y:33098,varname:node_953,prsc:2,v1:0.2;n:type:ShaderForge.SFN_Multiply,id:1435,x:33060,y:32862,varname:node_1435,prsc:2|A-585-RGB,B-7313-OUT,C-4872-OUT;n:type:ShaderForge.SFN_VertexColor,id:585,x:32745,y:32737,varname:node_585,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:4872,x:32959,y:33021,ptovrint:False,ptlb:Brightness,ptin:_Brightness,varname:node_4872,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:6272,x:31314,y:33627,ptovrint:False,ptlb:Line Amount,ptin:_LineAmount,varname:node_2119,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:50;n:type:ShaderForge.SFN_Multiply,id:1593,x:31522,y:33480,varname:node_1593,prsc:2|A-1991-UVOUT,B-6272-OUT;n:type:ShaderForge.SFN_Tex2d,id:5056,x:31864,y:33574,ptovrint:False,ptlb:Texture(mask),ptin:_Texturemask,varname:node_6349,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:854efec3a0dbc89439c19aef9bc88dda,ntxv:0,isnm:False|UVIN-1593-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3967,x:32707,y:33584,ptovrint:False,ptlb:Line Transparency,ptin:_LineTransparency,varname:node_2731,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Multiply,id:4691,x:33023,y:33506,varname:node_4691,prsc:2|A-5056-R,B-3967-OUT;n:type:ShaderForge.SFN_Blend,id:3619,x:33291,y:33432,cmnt:line blending,varname:node_3619,prsc:2,blmd:19,clmp:True|SRC-4691-OUT,DST-2447-OUT;n:type:ShaderForge.SFN_Multiply,id:2447,x:33023,y:33369,varname:node_2447,prsc:2|A-7558-OUT,B-4272-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4272,x:32807,y:33414,ptovrint:False,ptlb:Transparency,ptin:_Transparency,varname:node_9035,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;proporder:186-5056-5382-4872-6272-3967-4272;pass:END;sub:END;*/

Shader "Shader Forge/rgb sep" {
    Properties {
        _MainTex ("MainTex", 2D) = "white" {}
        _Texturemask ("Texture(mask)", 2D) = "white" {}
        _RGB ("RGB", Range(0, 1)) = 0
        _Brightness ("Brightness", Float ) = 1
        _LineAmount ("Line Amount", Float ) = 50
        _LineTransparency ("Line Transparency", Float ) = 0.1
        _Transparency ("Transparency", Float ) = 1
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
        [MaterialToggle] PixelSnap ("Pixel snap", Float) = 0
        _Stencil ("Stencil ID", Float) = 0
        _StencilReadMask ("Stencil Read Mask", Float) = 255
        _StencilWriteMask ("Stencil Write Mask", Float) = 255
        _StencilComp ("Stencil Comparison", Float) = 8
        _StencilOp ("Stencil Operation", Float) = 0
        _StencilOpFail ("Stencil Fail Operation", Float) = 0
        _StencilOpZFail ("Stencil Z-Fail Operation", Float) = 0
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
            "CanUseSpriteAtlas"="True"
            "PreviewType"="Plane"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            Cull Off
            ZWrite Off
            
            Stencil {
                Ref [_Stencil]
                ReadMask [_StencilReadMask]
                WriteMask [_StencilWriteMask]
                Comp [_StencilComp]
                Pass [_StencilOp]
                Fail [_StencilOpFail]
                ZFail [_StencilOpZFail]
            }
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #pragma multi_compile _ PIXELSNAP_ON
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float _RGB;
            uniform float _Brightness;
            uniform float _LineAmount;
            uniform sampler2D _Texturemask; uniform float4 _Texturemask_ST;
            uniform float _LineTransparency;
            uniform float _Transparency;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = UnityObjectToClipPos( v.vertex );
                #ifdef PIXELSNAP_ON
                    o.pos = UnityPixelSnap(o.pos);
                #endif
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float2 node_903 = (i.uv0+_RGB*float2(0,0));
                float4 node_1807 = tex2D(_MainTex,TRANSFORM_TEX(node_903, _MainTex));
                float2 node_239 = (i.uv0+_RGB*float2(0.05,0));
                float4 node_6883 = tex2D(_MainTex,TRANSFORM_TEX(node_239, _MainTex));
                float2 node_630 = (i.uv0+_RGB*float2(-0.05,0));
                float4 _node_123_copy = tex2D(_MainTex,TRANSFORM_TEX(node_630, _MainTex));
                float3 emissive = (i.vertexColor.rgb*float3(node_1807.r,node_6883.g,_node_123_copy.b)*_Brightness);
                float3 finalColor = emissive;
                float2 node_1593 = (i.uv0*_LineAmount);
                float4 _Texturemask_var = tex2D(_Texturemask,TRANSFORM_TEX(node_1593, _Texturemask));
                float node_953 = 0.2;
                return fixed4(finalColor,saturate(((saturate(((node_1807.r*node_953)+(node_6883.g*node_953)+(_node_123_copy.b*node_953)))*_Transparency)-(_Texturemask_var.r*_LineTransparency))));
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
            #pragma multi_compile _ PIXELSNAP_ON
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
                #ifdef PIXELSNAP_ON
                    o.pos = UnityPixelSnap(o.pos);
                #endif
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
