Shader "Amencioglu/FX/Desaturate01" {
	Properties {
		_Cutoff ("Mask Clip Value", Float) = 0.5
		_Opacity ("Opacity", Range(0, 1)) = 0
		_DissolvetoSaturate ("DissolvetoSaturate", Range(0, 1)) = 0
		_TextureSample3 ("Texture Sample 3", 2D) = "white" {}
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
	Fallback "Diffuse"
	//CustomEditor "ASEMaterialInspector"
}