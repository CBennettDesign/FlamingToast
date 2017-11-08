// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:3,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:False,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:33368,y:32729,varname:node_2865,prsc:2|emission-1714-OUT,alpha-1708-OUT;n:type:ShaderForge.SFN_Color,id:6301,x:32394,y:32815,ptovrint:False,ptlb:colour,ptin:_colour,varname:node_6301,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4139273,c2:0.6712803,c3:0.8529412,c4:1;n:type:ShaderForge.SFN_Slider,id:1719,x:32354,y:33227,ptovrint:False,ptlb:opacity,ptin:_opacity,varname:node_1719,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:1708,x:32926,y:33074,varname:node_1708,prsc:2|A-4883-OUT,B-1719-OUT,C-9555-A;n:type:ShaderForge.SFN_VertexColor,id:9555,x:32726,y:33289,varname:node_9555,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:5594,x:32177,y:32646,ptovrint:False,ptlb:mask,ptin:_mask,varname:node_5594,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-91-OUT;n:type:ShaderForge.SFN_Multiply,id:1714,x:32694,y:32704,varname:node_1714,prsc:2|A-8022-OUT,B-4072-OUT,C-6301-RGB;n:type:ShaderForge.SFN_ValueProperty,id:8022,x:32464,y:32507,ptovrint:False,ptlb:mask amount,ptin:_maskamount,varname:node_8022,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:4072,x:32374,y:32604,varname:node_4072,prsc:2|A-5255-OUT,B-5594-RGB;n:type:ShaderForge.SFN_ValueProperty,id:5255,x:32177,y:32570,ptovrint:False,ptlb:mask opacity,ptin:_maskopacity,varname:node_5255,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_TexCoord,id:8302,x:31513,y:32652,varname:node_8302,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:9507,x:31794,y:32674,varname:node_9507,prsc:2,spu:1,spv:0.1|UVIN-8302-UVOUT;n:type:ShaderForge.SFN_SwitchProperty,id:91,x:31962,y:32552,ptovrint:False,ptlb:pan?,ptin:_pan,varname:node_91,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-8302-UVOUT,B-9507-UVOUT;n:type:ShaderForge.SFN_Vector1,id:7390,x:31513,y:32794,varname:node_7390,prsc:2,v1:0;n:type:ShaderForge.SFN_RemapRange,id:9107,x:31513,y:32950,varname:node_9107,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-8302-V;n:type:ShaderForge.SFN_Negate,id:8927,x:31513,y:33120,varname:node_8927,prsc:2|IN-9107-OUT;n:type:ShaderForge.SFN_Blend,id:7888,x:31693,y:33028,varname:node_7888,prsc:2,blmd:17,clmp:True|SRC-9107-OUT,DST-8927-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:5293,x:32203,y:33028,ptovrint:False,ptlb:vertical blend?,ptin:_verticalblend,varname:node_5293,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:True|A-7804-OUT,B-1546-OUT;n:type:ShaderForge.SFN_Vector1,id:7804,x:32203,y:32945,varname:node_7804,prsc:2,v1:1;n:type:ShaderForge.SFN_RemapRange,id:504,x:31867,y:33028,varname:node_504,prsc:2,frmn:0,frmx:1,tomn:0,tomx:2|IN-7888-OUT;n:type:ShaderForge.SFN_Clamp01,id:333,x:32383,y:33028,varname:node_333,prsc:2|IN-5293-OUT;n:type:ShaderForge.SFN_Multiply,id:1546,x:32033,y:33028,varname:node_1546,prsc:2|A-8064-OUT,B-7888-OUT;n:type:ShaderForge.SFN_Slider,id:8064,x:31789,y:32941,ptovrint:False,ptlb:vertical blend amount,ptin:_verticalblendamount,varname:node_8064,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.367521,max:10;n:type:ShaderForge.SFN_OneMinus,id:4883,x:32538,y:33028,varname:node_4883,prsc:2|IN-333-OUT;proporder:6216-6301-1719-5594-8022-5255-91-5293-8064;pass:END;sub:END;*/

Shader "Shader Forge/test" {
    Properties {
        _node_7966 ("node_7966", 2D) = "white" {}
        _colour ("colour", Color) = (0.4139273,0.6712803,0.8529412,1)
        _opacity ("opacity", Range(0, 1)) = 1
        _mask ("mask", 2D) = "white" {}
        _maskamount ("mask amount", Float ) = 0
        _maskopacity ("mask opacity", Float ) = 0
        [MaterialToggle] _pan ("pan?", Float ) = 0
        [MaterialToggle] _verticalblend ("vertical blend?", Float ) = 1.367521
        _verticalblendamount ("vertical blend amount", Range(0, 10)) = 1.367521
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
            uniform float4 _colour;
            uniform float _opacity;
            uniform sampler2D _mask; uniform float4 _mask_ST;
            uniform float _maskamount;
            uniform float _maskopacity;
            uniform fixed _pan;
            uniform fixed _verticalblend;
            uniform float _verticalblendamount;
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
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float4 node_2285 = _Time;
                float2 _pan_var = lerp( i.uv0, (i.uv0+node_2285.g*float2(1,0.1)), _pan );
                float4 _mask_var = tex2D(_mask,TRANSFORM_TEX(_pan_var, _mask));
                float3 emissive = (_maskamount*(_maskopacity*_mask_var.rgb)*_colour.rgb);
                float3 finalColor = emissive;
                float node_9107 = (i.uv0.g*2.0+-1.0);
                float node_8927 = (-1*node_9107);
                float node_7888 = saturate(abs(node_9107-node_8927));
                float _verticalblend_var = lerp( 1.0, (_verticalblendamount*node_7888), _verticalblend );
                float node_1708 = ((1.0 - saturate(_verticalblend_var))*_opacity*i.vertexColor.a);
                fixed4 finalRGBA = fixed4(finalColor,node_1708);
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
            uniform float4 _colour;
            uniform sampler2D _mask; uniform float4 _mask_ST;
            uniform float _maskamount;
            uniform float _maskopacity;
            uniform fixed _pan;
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
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : SV_Target {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float4 node_3196 = _Time;
                float2 _pan_var = lerp( i.uv0, (i.uv0+node_3196.g*float2(1,0.1)), _pan );
                float4 _mask_var = tex2D(_mask,TRANSFORM_TEX(_pan_var, _mask));
                o.Emission = (_maskamount*(_maskopacity*_mask_var.rgb)*_colour.rgb);
                
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
