// DrawBase.CLR.cpp : main project file.

#include "stdafx.h"

using namespace System;

int main(array<System::String ^> ^args)
{
    Console::WriteLine(L"Hello World");
    return 0;
}

//ref class ManagedFoo
//{
//public:
//	ManagedFoo()
//	{
//		Console::WriteLine("Constructing ManagedFoo");
//		m_foo = new UnmanagedFoo();
//		if (!m_foo) {
//			throw gcnew OutOfMemoryException();
//		}
//	}