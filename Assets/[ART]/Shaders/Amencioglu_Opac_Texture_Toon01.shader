Shader "Amencioglu/Opac/Texture/Toon01" {
	Properties {
		_Texture1 ("Texture", 2D) = "white" {}
		_ColorContrast ("ColorContrast", Float) = 1
		_WorldNormal ("WorldNormal", Float) = 0.3
		_Smoothness ("Smoothness", Range(0, 1)) = 0
		_Albedo ("Albedo", Range(0, 1)) = 0.3
		_Emission ("Emission", Range(0, 1)) = 0.85
		_Desaturation ("Desaturation", Range(0, 1)) = 0
		[Toggle] _TintColorEmissionONOFF ("TintColor Emission ON/OFF", Float) = 0
		[Toggle] _TintColorAlbedoONOFF ("TintColor Albedo ON/OFF", Float) = 0
		_TintColor ("TintColor", Vector) = (0,0,0,0)
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