// dllmain.cpp : Defines the entry point for the DLL application.
//#include "stdafx.h"

#pragma once
//#include "targetver.h"
//#define WIN32_LEAN_AND_MEAN  

#include <windows.h>
#include <stdio.h>




typedef tagRGBTRIPLE *PRGBTriple;
typedef PRGBTriple *ptrPRGBTriple;


enum TPixelFormat : unsigned char { pfDevice, pf1bit, pf4bit, pf8bit, pf15bit, pf16bit, pf24bit, pf32bit, pfCustom };

struct TBmpbuf // буфер для передачи изображения
{
    int width; // ширина изображения
    int height; // высота изображения
    TPixelFormat pixelFormat;
    int reserve; // зарезервировано
    ptrPRGBTriple pixels; // указатель на массивы rgb-значений пикселей
};

typedef TBmpbuf *PBmpBuf;
PRGBTriple rowSRC;

//#define _DECLARATOR_ __declspec(dllexport)








void* inversion(void* BufBmp)
{
	



	for (int j = 0; j < ((PBmpBuf) BufBmp)->height; j++)
    {
	rowSRC = ((PBmpBuf) BufBmp)->pixels[j];	
     for (int i = 0; i < ((PBmpBuf) BufBmp)->width; i++)
       {
  	     rowSRC[i].rgbtBlue=255 - rowSRC[i].rgbtBlue;
	     rowSRC[i].rgbtGreen = 255 - rowSRC[i].rgbtGreen;
	     rowSRC[i].rgbtRed = 255 - rowSRC[i].rgbtRed;



       } 

     }


return BufBmp;
}



BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
					 )
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}

	return TRUE;
}

