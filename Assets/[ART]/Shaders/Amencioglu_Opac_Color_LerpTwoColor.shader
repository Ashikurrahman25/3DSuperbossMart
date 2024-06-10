Shader "Amencioglu/Opac/Color/LerpTwoColor" {
	Properties {
		_Mask ("Mask", 2D) = "white" {}
		_Color1 ("Color 1", Vector) = (0.3207547,0.1070996,0,0)
		_Color2 ("Color 2", Vector) = (1,0.4555214,0.0990566,0)
		_Diffuse ("Diffuse", Range(0, 1)) = 0
		_Emission ("Emission", Range(0, 1)) = 0
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