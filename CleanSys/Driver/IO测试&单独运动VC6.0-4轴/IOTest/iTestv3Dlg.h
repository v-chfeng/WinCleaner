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
	CPoint point;				//�ͻ���ԭ��
	CSize szRtLamp;				//Lamp���ε�size
	CPoint m_ptGenIn;			//��ͨ�����롱����ʼ��
	CPoint m_ptGenOut;			//��ͨ�����������ʼ��
	CPoint m_ptExtIn;			//����չ���롱����ʼ��
	CPoint m_ptLmitBit;			//����λ������ʼ��
	CPoint m_ptExtOut;			//����չ���������ʼ��
	int m_nFontHeight;			//����������߶�
	int m_nNumHeight;			//����������ֺ�
	int m_nSpace;				//Lamp֮��ļ��
	CRect m_rtLamp;				//�洢��Lamp����
	CRect m_rect;				//�����洢�ͻ���
	CRect m_rtGenIN[8];			//�洢ͨ������Lamp����	
	CRect m_rtGenOUT[8];		//�洢ͨ�����Lamp����
	CRect m_rtExtIN[40];		//�洢��չ����Lamp����
	CRect m_rtLmtBit[12];		//�洢��λLamp����
	CRect m_rtExtOUT[24];		//�洢��չ�������
	int	  m_iLastGenIN;			//�洢ǰһ�ε�ͨ�������ź�
	int	  m_iLastGenOUT;		//�洢ǰһ�ε�ͨ������ź�
	int   m_iLastExtIN[5];		//�洢ǰһ�ε���չ�����ź�
	int   m_bLastLmtBit[12];	//�洢ǰһ�ε���λ�ź�
	int   m_iLastExtOUT[3];		//�洢ǰһ�ε���չ����ź�
	int	  m_iFlagGenIN;			//�洢��һ�ε�ͨ�������ź�
	int	  m_iFlagGenOUT;		//�洢��һ�ε�ͨ������ź�
	int   m_iFlagExtIN[5];		//�洢��һ�ε���չ�����ź�
	int   m_bFlagLmtBit[12];	//�洢��һ�ε���λ�ź�
	int   m_iFlagExtOUT[3];		//�洢��һ�ε���չ����ź�

	CRect m_rtBtnGenAllOut;		//�洢��ȫ��ͨ��������ľ���
	CRect m_rtBtnEmgStop;		//�洢����ͣ���ľ���
	CRect m_rtBtnExtAllOut;		//�洢��ȫ����չ������ľ���
	CRect m_rtBtnGenSerOut;		//�洢��ͨ������������ľ���
	CRect m_rtBtnExtSerOut;		//�洢����չ����������ľ���

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
