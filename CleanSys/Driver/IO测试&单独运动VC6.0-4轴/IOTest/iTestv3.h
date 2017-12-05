// iTestv3.h : main header file for the ITESTV3 application
//

#if !defined(AFX_ITESTV3_H__573DC2E1_70F8_4FDF_96F6_EA7F135B435E__INCLUDED_)
#define AFX_ITESTV3_H__573DC2E1_70F8_4FDF_96F6_EA7F135B435E__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CITestv3App:
// See iTestv3.cpp for the implementation of this class
//

class CITestv3App : public CWinApp
{
public:
	CITestv3App();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CITestv3App)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CITestv3App)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ITESTV3_H__573DC2E1_70F8_4FDF_96F6_EA7F135B435E__INCLUDED_)
