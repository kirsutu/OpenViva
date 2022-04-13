﻿Shader "Unlit/bubbleMeter3"
{
	Properties
	{
		_TexA ("Texture A", 2D) = "white" {}
		_TexB ("Texture B", 2D) = "white" {}
	}
	SubShader
	{
		Tags {
			"Queue"="Transparent" 
			"RenderType"="Transparent"
		}
		LOD 100

		Cull off
		ZWrite Off
		Blend SrcAlpha OneMinusSrcAlpha

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			// make fog work
			#pragma multi_compile_fog
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float3 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			sampler2D _TexA;
			sampler2D _TexB;
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv.xy = v.uv;
				o.uv.z = sin(_Time.w)*.5+.5;
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				fixed4 colA = tex2D(_TexA, i.uv.xy);
				fixed4 colB = tex2D(_TexB, i.uv.xy);
				return fixed4( lerp(colA.rgb,colB.rgb,i.uv.z), colA.a );
			}
			ENDCG
		}
	}
}
