//UNITY_SHADER_NO_UPGRADE
#ifndef MYHLSLINCLUDE_INCLUDED
#define MYHLSLINCLUDE_INCLUDED


float3 _TestUniform1;

void customPosition_float( float3 inPosition, float4 audioinfo , out float3 OUT ){
    OUT= inPosition + sin(audioinfo.xyz);
}

#endif //MYHLSLINCLUDE_INCLUDED