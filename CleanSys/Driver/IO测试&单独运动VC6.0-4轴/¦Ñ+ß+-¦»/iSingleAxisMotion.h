// iSingleAxisMotion.h : main header file for the ISINGLEAXISMOTION application
//

#if !defined(AFX_ISINGLEAXISMOTION_H__B28441B0_0090_4F55_AF3D_D9778F653B8B__INCLUDED_)
#define AFX_ISINGLEAXISMOTION_H__B28441B0_0090_4F55_AF3D_D9778F653B8B__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CISingleAxisMotionApp:
// See iSingleAxisMotion.cpp for the implementation of this class
//

class CISingleAxisMotionApp : public CWinApp
{
public:
	CISingleAxisMotionApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CISingleAxisMotionApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CISingleAxisMotionApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ISINGLEAXISMOTION_H__B28441B0_0090_4F55_AF3D_D9778F653B8B__INCLUDED_)
