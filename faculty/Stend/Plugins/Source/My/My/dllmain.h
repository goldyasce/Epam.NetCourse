#ifdef _DLLEXPORT_
  #define _DECLARATOR_ __declspec(dllexport)
#else
  #define _DECLARATOR_ __declspec(dllimport)
#endif

extern "C"
{
  void*  _DECLARATOR_  __cdecl inversion(void* BufBmp);
}

extern "C"
{

}


