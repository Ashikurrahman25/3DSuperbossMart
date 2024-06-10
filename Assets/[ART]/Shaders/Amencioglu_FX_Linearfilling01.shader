Shader "Amencioglu/FX/Linearfilling01" {
	Properties {
		_FirstColor ("FirstColor", Vector) = (0,0,0,0)
		_SecondColor ("Second Color", Vector) = (1,1,1,0)
		_StrokeColor ("StrokeColor", Vector) = (0.507209,0.7414559,0.7735849,0)
		_Process ("Process", Range(0, 1)) = 0
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