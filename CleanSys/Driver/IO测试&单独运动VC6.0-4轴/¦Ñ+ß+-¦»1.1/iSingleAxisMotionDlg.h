// iSingleAxisMotionDlg.h : header file
//

#if !defined(AFX_ISINGLEAXISMOTIONDLG_H__EFAD0B3C_72C2_4174_9289_A522ACE286EB__INCLUDED_)
#define AFX_ISINGLEAXISMOTIONDLG_H__EFAD0B3C_72C2_4174_9289_A522ACE286EB__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include "galil/Dmcwin.h"
extern int logic;
extern USHORT g_nController;
extern long g_lRc;
/////////////////////////////////////////////////////////////////////////////
// CISingleAxisMotionDlg dialog

class CISingleAxisMotionDlg : public CDialog
{
// Construction
public:
	CISingleAxisMotionDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CISingleAxisMotionDlg)
	enum { IDD = IDD_ISINGLEAXISMOTION_DIALOG };
	BOOL	m_bLogic;
	long	m_lSpeed;
	long	m_lSacc;
	long	m_lSdec;
	int		m_nSpeedst;
	long	m_lPulse;
	int		m_iRadioAxis;
	int		m_iActionPoint;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CISingleAxisMotionDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CISingleAxisMotionDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnDestroy();
	afx_msg void OnTimer(UINT nIDEvent);
	afx_msg void OnBtnPosZero();
	afx_msg void OnBtnEmgStop();
	afx_msg void OnBtnStop();
	afx_msg void OnRadioCmove();
	afx_msg void OnRadioActionst();
	afx_msg void OnBtnDo();
	afx_msg void OnRadioXAxs();
	afx_msg void OnRadioYAxs();
	afx_msg void OnRadioZAxs();
	afx_msg void OnRadioWAxs();
	afx_msg void OnBtnretzero();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
private:
	CDMCWin m_DMCWin;

public:
	void OnCheckLogic();
	void UpdateControl();
	void InitCtrl();
	int  GetStatus();
	long GetPosition();
	int		m_nAxis;
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ISINGLEAXISMOTIONDLG_H__EFAD0B3C_72C2_4174_9289_A522ACE286EB__INCLUDED_)
