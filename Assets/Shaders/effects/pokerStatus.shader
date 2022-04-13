﻿
Shader "Effects/PokerStatus"
{
	Properties
	{
		_MainTex ("Poker Symbol Texture", 2D) = "white" {}
	}
	SubShader
	{
		
		Tags {
			"Queue" = "Transparent+1"
			"RenderType"="Transparent"
		}
		LOD 100

		Cull Off
		ZWrite Off
		ZTest Less

		Blend SrcAlpha OneMinusSrcAlpha


		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			sampler2D _MainTex;
			
			v2f vert (appdata v)
			{
				v2f o;
				float scale = 0.95+abs(sin(_Time.w)*0.1);
                o.vertex = UnityObjectToClipPos(v.vertex*scale);
				o.uv = v.uv;
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				fixed4 color = tex2D( _MainTex, i.uv );
				fixed fluc = sin((i.uv.x+i.uv.y)*16.0+_Time.w)*0.4;
				color.rgb += fluc*color.a*0.5;
				return color;
			}
			ENDCG
		}
	}
}
