#ifndef DYNAMIC_RADIAL_MASKS_RINGS_1_ADVANCED_ADDITIVE_ID1_LOCAL
#define DYNAMIC_RADIAL_MASKS_RINGS_1_ADVANCED_ADDITIVE_ID1_LOCAL


#ifndef DYNAMIC_RADIAL_MASKS_VARIABLES_DECLARED_IN_CBUFFER
float4 DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local_DATA1[1];	
float4 DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local_DATA2[1];	
float4 DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local_DATA3[1];	
#endif

#include "../../Core/Core.cginc"



////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                                Main Method                                 //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
float DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local(float3 positionWS, float noise
#ifdef DYNAMIC_RADIAL_MASKS_VARIABLES_DECLARED_IN_CBUFFER
,
float4 DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local_DATA1[1],
float4 DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local_DATA2[1],	
float4 DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local_DATA3[1]	
#endif
)
{
    float retValue = 0; 

	int i = 0;

	{
		retValue += ShaderExtensions_DynamicRadialMasks_Rings_Advanced(positionWS, 
																					DYNAMIC_RADIAL_MASKS_READ_POSITION(DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local, i), 
																					DYNAMIC_RADIAL_MASKS_READ_RADIUS(DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local, i), 
																					DYNAMIC_RADIAL_MASKS_READ_INTENSITY(DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local, i), 
																					DYNAMIC_RADIAL_MASKS_READ_EDGE_SIZE(DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local, i), 
																					DYNAMIC_RADIAL_MASKS_READ_RING_COUNT(DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local, i), 
																					DYNAMIC_RADIAL_MASKS_READ_SMOOTH(DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local, i), 
																					DYNAMIC_RADIAL_MASKS_READ_NOISE_STRENGTH(DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local, i) * noise);
	}		

    return retValue;
}

////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                               Helper Methods                               //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
void DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local_float(float3 positionWS, float noise, out float retValue)
{
    #ifdef DYNAMIC_RADIAL_MASKS_VARIABLES_DECLARED_IN_CBUFFER
		retValue = 0;
	#else
		retValue = DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local(positionWS, noise); 	
	#endif
}

void DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local_half(half3 positionWS, half noise, out half retValue)
{
    #ifdef DYNAMIC_RADIAL_MASKS_VARIABLES_DECLARED_IN_CBUFFER
		retValue = 0;
	#else
		retValue = DynamicRadialMasks_Rings_1_Advanced_Additive_ID1_Local(positionWS, noise); 	
	#endif
}

#endif
