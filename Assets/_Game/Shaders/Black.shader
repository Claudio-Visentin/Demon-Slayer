// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/Black" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_Glossiness ("Smoothness", Range(0,1)) = 0.5
		_Metallic ("Metallic", Range(0,1)) = 0.0
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass {
	CGPROGRAM

	#pragma vertex vert             
	#pragma fragment frag

	struct vertInput {
		float4 pos : POSITION;
	};

	struct vertOutput {
		float4 pos : SV_POSITION;
	};

	vertOutput vert(vertInput input) {
		vertOutput o;
		o.pos = UnityObjectToClipPos(input.pos);
		return o;
	}

	half4 frag(vertOutput output) : COLOR {
		return half4(0.0, 0.0, 0.0, 0.0);
	}
	ENDCG
}
	}
	FallBack "Diffuse"
}
