#ifndef DYNAMIC_RADIAL_MASKS_DOT_8_ADVANCED_ADDITIVE_ID3_LOCAL
#define DYNAMIC_RADIAL_MASKS_DOT_8_ADVANCED_ADDITIVE_ID3_LOCAL


#ifndef DYNAMIC_RADIAL_MASKS_VARIABLES_DECLARED_IN_CBUFFER
float4 DynamicRadialMasks_Dot_8_Advanced_Additive_ID3_Local_DATA1[8];	
float4 DynamicRadialMasks_Dot_8_Advanced_Additive_ID3_Local_DATA2[8];
#endif

#include "../../Core/Core.cginc"



////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                                Main Method                                 //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
float DynamicRadialMasks_Dot_8_Advanced_Additive_ID3_Local(float3 positionWS, float noise
#ifdef DYNAMIC_RADIAL_MASKS_VARIABLES_DECLARED_IN_CBUFFER
,
float4 DynamicRadialMasks_Dot_8_Advanced_Additive_ID3_Local_DATA1[8],
float4 DynamicRadialMasks_Dot_8_Advanced_Additive_ID3_Local_DATA2[8]
#endif
)
{
    float retValue = 0; 

	int i = 0;
[unroll]	for(i = 0; i < 8; i++)
	{
		retValue += ShaderExtensions_DynamicRadialMasks_Dot_Advanced(positionWS, 
																					DYNAMIC_RADIAL_MASKS_READ_POSITION(DynamicRadialMasks_Dot_8_Advanced_Additive_ID3_Local, i), 
																					DYNAMIC_RADIAL_MASKS_READ_RADIUS(DynamicRadialMasks_Dot_8_Advanced_Additive_ID3_Local, i), 
																					DYNAMIC_RADIAL_MASKS_READ_INTENSITY(DynamicRadialMasks_Dot_8_Advanced_Additive_ID3_Local, i), 
																					DYNAMIC_RADIAL_MASKS_READ_NOISE_STRENGTH(DynamicRadialMasks_Dot_8_Advanced_Additive_ID3_Local, i) * noise);
	}		

    return retValue;
}

////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                               Helper Methods                               //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
void DynamicRadialMasks_Dot_8_Advanced_Additive_ID3_Local_float(float3 positionWS, float noise, out float retValue)
{
    #ifdef DYNAMIC_RADIAL_MASKS_VARIABLES_DECLARED_IN_CBUFFER
		retValue = 0;
	#else
		retValue = DynamicRadialMasks_Dot_8_Advanced_Additive_ID3_Local(positionWS, noise); 	
	#endif
}

void DynamicRadialMasks_Dot_8_Advanced_Additive_ID3_Local_half(half3 positionWS, half noise, out half retValue)
{
    #ifdef DYNAMIC_RADIAL_MASKS_VARIABLES_DECLARED_IN_CBUFFER
		retValue = 0;
	#else
		retValue = DynamicRadialMasks_Dot_8_Advanced_Additive_ID3_Local(positionWS, noise); 	
	#endif
}

#endif
