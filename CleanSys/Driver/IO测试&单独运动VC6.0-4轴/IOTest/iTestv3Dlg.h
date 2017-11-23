// iTestv3Dlg.h : header file
//

#if !defined(AFX_ITESTV3DLG_H__6CD0F740_EC18_49B8_B876_2A866F6604BE__INCLUDED_)
#define AFX_ITESTV3DLG_H__6CD0F740_EC18_49B8_B876_2A866F6604BE__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include "galil/Dmcwin.h"
/////////////////////////////////////////////////////////////////////////////
// CITestv3Dlg dialog
class CITestv3Dlg : public CDialog
{
// Construction
public:
	CITestv3Dlg(CWnd* pParent = NULL);	// standard constructor
	void DrawLamp();
	void GetExtOutStatus();
	void GetGenOutStatus();
	void GetLmtBit();
	void GetExtInStatus();
	void GetGenInStatus();
	static DWORD __stdcall ThreadFunOne(LPVOID lpParam);
	static DWORD __stdcall ThreadFunTwo(LPVOID lpParam);

public:
	CDMCWin m_DMCWin;		
	CPoint point;				//客户区原点
	CSize szRtLamp;				//Lamp矩形的size
	CPoint m_ptGenIn;			//“通用输入”的起始点
	CPoint m_ptGenOut;			//“通用输出”的起始点
	CPoint m_ptExtIn;			//“扩展输入”的起始点
	CPoint m_ptLmitBit;			//“限位”的起始点
	CPoint m_ptExtOut;			//“扩展输出”的起始点
	int m_nFontHeight;			//界面中字体高度
	int m_nNumHeight;			//界面中序号字号
	int m_nSpace;				//Lamp之间的间距
	CRect m_rtLamp;				//存储的Lamp矩形
	CRect m_rect;				//用来存储客户区
	CRect m_rtGenIN[8];			//存储通用输入Lamp矩形	
	CRect m_rtGenOUT[8];		//存储通用输出Lamp矩形
	CRect m_rtExtIN[40];		//存储扩展输入Lamp矩形
	CRect m_rtLmtBit[12];		//存储限位Lamp矩形
	CRect m_rtExtOUT[24];		//存储扩展输出矩形
	int	  m_iLastGenIN;			//存储前一次的通用输入信号
	int	  m_iLastGenOUT;		//存储前一次的通用输出信号
	int   m_iLastExtIN[5];		//存储前一次的扩展输入信号
	int   m_bLastLmtBit[12];	//存储前一次的限位信号
	int   m_iLastExtOUT[3];		//存储前一次的扩展输出信号
	int	  m_iFlagGenIN;			//存储这一次的通用输入信号
	int	  m_iFlagGenOUT;		//存储这一次的通用输出信号
	int   m_iFlagExtIN[5];		//存储这一次的扩展输入信号
	int   m_bFlagLmtBit[12];	//存储这一次的限位信号
	int   m_iFlagExtOUT[3];		//存储这一次的扩展输出信号

	CRect m_rtBtnGenAllOut;		//存储“全部通用输出”的矩形
	CRect m_rtBtnEmgStop;		//存储“急停”的矩形
	CRect m_rtBtnExtAllOut;		//存储“全部扩展输出”的矩形
	CRect m_rtBtnGenSerOut;		//存储“通用依次输出”的矩形
	CRect m_rtBtnExtSerOut;		//存储“扩展依次输出”的矩形

	HANDLE m_hThreadOne;
	HANDLE m_hThreadTwo;
	
// Dialog Data
	//{{AFX_DATA(CITestv3Dlg)
	enum { IDD = IDD_ITESTV3_DIALOG };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CITestv3Dlg)
	public:
	virtual BOOL DestroyWindow();
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CITestv3Dlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnTimer(UINT nIDEvent);
	afx_msg void OnLButtonDown(UINT nFlags, CPoint point);
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ITESTV3DLG_H__6CD0F740_EC18_49B8_B876_2A866F6604BE__INCLUDED_)
