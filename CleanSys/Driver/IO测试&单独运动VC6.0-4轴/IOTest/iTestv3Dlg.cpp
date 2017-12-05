// iTestv3Dlg.cpp : implementation file
//

#include "stdafx.h"
#include "iTestv3.h"
#include "iTestv3Dlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	//{{AFX_DATA(CAboutDlg)
	enum { IDD = IDD_ABOUTBOX };
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CAboutDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	//{{AFX_MSG(CAboutDlg)
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
	//{{AFX_DATA_INIT(CAboutDlg)
	//}}AFX_DATA_INIT
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CAboutDlg)
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
	//{{AFX_MSG_MAP(CAboutDlg)
		// No message handlers
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CITestv3Dlg dialog

CITestv3Dlg::CITestv3Dlg(CWnd* pParent /*=NULL*/)
	: CDialog(CITestv3Dlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CITestv3Dlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
	//初始化界面
	m_nSpace = 10;			
	m_nNumHeight = 14;		
	m_nFontHeight = 24;
	CPoint point(0,0);
	CRect rect(0,0,m_nFontHeight,m_nFontHeight);
	szRtLamp = rect.Size();
	m_rtLamp = new CRect(point, szRtLamp);
	m_ptGenIn.x = 20;
	m_ptGenIn.y = 0;
	m_ptGenOut.x = m_ptGenIn.x;
	m_ptGenOut.y = m_ptGenIn.y+m_nFontHeight+m_rtLamp.Height()+m_nNumHeight+m_nSpace;
	m_ptExtIn.x = m_ptGenIn.x;
	m_ptExtIn.y = m_ptGenOut.y+m_nFontHeight+m_rtLamp.Height()+m_nNumHeight+m_nSpace;
	m_ptLmitBit.x = m_ptGenIn.x;
	m_ptLmitBit.y = m_ptExtIn.y+m_nFontHeight+3*(m_rtLamp.Height()+m_nNumHeight)+m_nSpace;
	m_ptExtOut.x = m_ptGenIn.x;
	m_ptExtOut.y = m_ptLmitBit.y+m_nFontHeight+m_rtLamp.Height()+m_nNumHeight+m_nSpace;
	//初始化灯信号值
	m_iLastGenIN = 255;
	m_iLastGenOUT = 0;
	for(int i=0; i<5; i++)
	{
		m_iLastExtIN[i] = 255;
	}
	for(i=0; i<12; i++)
	{
		m_bLastLmtBit[i] = FALSE;
	}
	for(i=0; i<3; i++)
	{
		m_iLastExtOUT[i] = 0;
	}
	m_iFlagGenIN = 255;
	m_iFlagGenOUT = 0;
	for(i=0; i<5; i++)
	{
		m_iFlagExtIN[i] = 255;
	}
	for(i=0; i<12; i++)
	{
		m_bFlagLmtBit[i] = FALSE;
	}
	for(i=0; i<3; i++)
	{
		m_iFlagExtOUT[i] = 0;
	}
}

void CITestv3Dlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CITestv3Dlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CITestv3Dlg, CDialog)
	//{{AFX_MSG_MAP(CITestv3Dlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_TIMER()
	ON_WM_LBUTTONDOWN()
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CITestv3Dlg message handlers

BOOL CITestv3Dlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon
	
	// TODO: Add extra initialization here

	//设置窗口大小
	this->MoveWindow(200, 200, 25*m_rtLamp.Width(), 22*m_rtLamp.Height());
	
	//设置定时器
	SetTimer(1,500,NULL);	//监控信号 
	
	//获取客户区矩形
	this->GetClientRect(m_rect);

	//给对话框加标题
	this->SetWindowText("iTestVer1.1@PowerLand");
	
	//打开控制器
	long l_lRes;
	l_lRes = m_DMCWin.Open(1);
	if(0!=l_lRes)
	{
		char szBuffer[30];
		sprintf(szBuffer, "控制器打开失败%d", l_lRes);
		MessageBox(szBuffer);
	}
	
	//查看是否设置了CO7,如未设，则设置CO7
	char szRes[80];
	char cCmd[80];
	sprintf(cCmd, "MG_CO7", 0);
	m_DMCWin.Command(cCmd, szRes, sizeof(szRes));
	if (7 != atoi(szRes)) 
	{
		m_DMCWin.Command("CO7");	
	}
	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CITestv3Dlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CITestv3Dlg::OnPaint() 
{
	DrawLamp();
	/*
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
	*/
}

// The system calls this to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CITestv3Dlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

void CITestv3Dlg::DrawLamp()
{
	//初始化双缓冲相关元素
	CPaintDC dc(this);
	CDC MemDC;
	CBitmap MemBitmap;
	MemDC.CreateCompatibleDC(NULL);
	MemBitmap.CreateCompatibleBitmap(&dc, m_rect.Width(), m_rect.Height());
	CBitmap *pOldBit = MemDC.SelectObject(&MemBitmap);
	MemDC.FillSolidRect(m_rect.TopLeft().x, m_rect.TopLeft().y, m_rect.Width(), m_rect.Height(), (COLORREF)0x00ffeddb);

	//向界面上加信号灯类别
	MemDC.TextOut(m_ptGenIn.x, m_ptGenIn.y, "通用输入");
	MemDC.TextOut(m_ptGenOut.x, m_ptGenOut.y, "通用输出");
	MemDC.TextOut(m_ptExtIn.x, m_ptExtIn.y, "扩展输入");
	MemDC.TextOut(m_ptLmitBit.x, m_ptLmitBit.y, "限位");
	MemDC.TextOut(m_ptExtOut.x, m_ptExtOut.y, "扩展输出");
	
	//创建新字体给灯写序号
	CFont newFont;
	newFont.CreateFont(12,          // nHeight
		0,                            // nWidth
		0,                            // nEscapement
		0,                            // nOrientation
		FW_NORMAL,                      // nWeight
		FALSE,                        // bItalic
		FALSE,                        // bUnderline
		0,                            // cStrikeOut
		ANSI_CHARSET,                 // nCharSet
		OUT_DEFAULT_PRECIS,           // nOutPrecision
		CLIP_DEFAULT_PRECIS,          // nClipPrecision
		DEFAULT_QUALITY,              // nQuality
		DEFAULT_PITCH | FF_SWISS,     // nPitchAndFamily
		_T("宋体"));                  // lpszFac

	//将新字体选中设备环境
	CFont* pOldFont = MemDC.SelectObject(&newFont);
	
	//通用输入的序号
	for(int j=0; j<8; j++)
	{
		CString str;
		str.Format("%d", j+1);
		int iLampHeight = m_rtLamp.Width();
		int iLampSpace = m_rtLamp.Width()+m_nSpace;
		MemDC.TextOut(m_ptGenIn.x+iLampHeight*0.4+iLampSpace*j, m_ptGenIn.y+m_nFontHeight+m_rtLamp.Height(), str);
	}
	//通用输出的序号
	for(j=0; j<8; j++)
	{
		CString str;
		str.Format("%d", j+1);
		int iLampHeight = m_rtLamp.Width();
		int iLampSpace = m_rtLamp.Width()+m_nSpace;
		MemDC.TextOut(m_ptGenOut.x+iLampHeight*0.4+iLampSpace*j, m_ptGenOut.y+m_nFontHeight+m_rtLamp.Height(), str);
	}

	//扩展输入的序号
	for(int i=0; i<2; i++)
	{
		for(int j=0; j<16; j++)
		{
			CString str;
			str.Format("%d", i*16+j+1);
			int iLampHeight = m_rtLamp.Width();
			int iLampSpace = m_rtLamp.Width()+m_nSpace;
			MemDC.TextOut(m_ptExtIn.x+iLampHeight*0.3+iLampSpace*j,
				m_ptExtIn.y+m_nFontHeight+m_rtLamp.Height()+(m_nFontHeight+m_nNumHeight)*i, str);
		}
	}
	for(i=2; i<3; i++)
	{
		for(int j=0; j<8; j++)
		{
			CString str;
			str.Format("%d", i*16+j+1);
			int iLampHeight = m_rtLamp.Width();
			int iLampSpace = m_rtLamp.Width()+m_nSpace;
			MemDC.TextOut(m_ptExtIn.x+iLampHeight*0.3+iLampSpace*j,
				m_ptExtIn.y+m_nFontHeight+m_rtLamp.Height()+(m_nFontHeight+m_nNumHeight)*i, str);
		}
	}
	
	//限位序号
	int iLampHeight = m_rtLamp.Width();
	int iLampSpace = m_rtLamp.Width()+m_nSpace;
	MemDC.TextOut(m_ptLmitBit.x+iLampHeight*0.2+iLampSpace*0, m_ptLmitBit.y+m_nFontHeight+m_rtLamp.Height(), "x+");
	MemDC.TextOut(m_ptLmitBit.x+iLampHeight*0.2+iLampSpace*1, m_ptLmitBit.y+m_nFontHeight+m_rtLamp.Height(), "x-");
	MemDC.TextOut(m_ptLmitBit.x+iLampHeight*0.2+iLampSpace*2, m_ptLmitBit.y+m_nFontHeight+m_rtLamp.Height(), "hmx");
	MemDC.TextOut(m_ptLmitBit.x+iLampHeight*0.2+iLampSpace*3, m_ptLmitBit.y+m_nFontHeight+m_rtLamp.Height(), "y+");
	MemDC.TextOut(m_ptLmitBit.x+iLampHeight*0.2+iLampSpace*4, m_ptLmitBit.y+m_nFontHeight+m_rtLamp.Height(), "y-");
	MemDC.TextOut(m_ptLmitBit.x+iLampHeight*0.2+iLampSpace*5, m_ptLmitBit.y+m_nFontHeight+m_rtLamp.Height(), "hmy");
	MemDC.TextOut(m_ptLmitBit.x+iLampHeight*0.2+iLampSpace*6, m_ptLmitBit.y+m_nFontHeight+m_rtLamp.Height(), "z+");
	MemDC.TextOut(m_ptLmitBit.x+iLampHeight*0.2+iLampSpace*7, m_ptLmitBit.y+m_nFontHeight+m_rtLamp.Height(), "z-");
	MemDC.TextOut(m_ptLmitBit.x+iLampHeight*0.2+iLampSpace*8, m_ptLmitBit.y+m_nFontHeight+m_rtLamp.Height(), "hmz");
	MemDC.TextOut(m_ptLmitBit.x+iLampHeight*0.2+iLampSpace*9, m_ptLmitBit.y+m_nFontHeight+m_rtLamp.Height(), "w+");
	MemDC.TextOut(m_ptLmitBit.x+iLampHeight*0.2+iLampSpace*10, m_ptLmitBit.y+m_nFontHeight+m_rtLamp.Height(), "w-");
	MemDC.TextOut(m_ptLmitBit.x+iLampHeight*0.2+iLampSpace*11, m_ptLmitBit.y+m_nFontHeight+m_rtLamp.Height(), "hmw");
	
	//扩展输出序号
	for(i=0; i<2; i++)
	{
		for(int j=0; j<12; j++)
		{
			CString str;
			str.Format("%d", i*12+j+1);
			int iLampHeight = m_rtLamp.Width();
			int iLampSpace = m_rtLamp.Width()+m_nSpace;
			MemDC.TextOut(m_ptExtOut.x+iLampHeight*0.2+iLampSpace*j,
				m_ptExtOut.y+m_nFontHeight+m_rtLamp.Height()+(m_nFontHeight+m_nNumHeight)*i, str);
		}
	}
		
	//绘制用于显示的灯
	//通用输入
	for(i=0; i<1; i++)
	{
		for(int j=0; j<8; j++)
		{
			CRect l_rect(&m_rtLamp);						 //确定矩形区域
			l_rect.left = m_ptGenIn.x + iLampSpace*j;
			l_rect.top = m_ptGenIn.y + m_nFontHeight;
			l_rect.right = l_rect.left + m_rtLamp.Width();
			l_rect.bottom = l_rect.top + m_rtLamp.Height();
			m_rtGenIN[j] = l_rect;							 //将矩形对象存入数组
			MemDC.Rectangle(l_rect);						 //向内存DC中画矩形
		}
	}
	//填充颜色
	for(i=0; i<8; i++)
	{
		int iRes = (m_iFlagGenIN & (1<<i) )>>i;
		if (0==iRes)	
		{
			MemDC.FillSolidRect(m_rtGenIN[i], (COLORREF)0x000000ff);//红色
		}
		else
		{
			MemDC.FillSolidRect(m_rtGenIN[i], (COLORREF)0x0000ff00);//绿色
		}	
	}
	
	//通用输出
	for(i=0; i<1; i++)
	{
		for(int j=0; j<8; j++)
		{
			CRect l_rect(&m_rtLamp);						 //确定矩形区域
			l_rect.left = m_ptGenOut.x + iLampSpace*j;
			l_rect.top = m_ptGenOut.y + m_nFontHeight;
			l_rect.right = l_rect.left + m_rtLamp.Width();
			l_rect.bottom = l_rect.top + m_rtLamp.Height();
			m_rtGenOUT[j] = l_rect;							 //将矩形对象存入数组
			MemDC.Rectangle(l_rect);						 //向内存DC中画矩形
		}
	}
	//填充颜色
	for(i=0; i<8; i++)
	{
		int iRes = (m_iFlagGenOUT & (1<<i) )>>i;
		if (1==iRes)	
		{
			MemDC.FillSolidRect(m_rtGenOUT[i], (COLORREF)0x000000ff);//红色
		}
		else
		{
			MemDC.FillSolidRect(m_rtGenOUT[i], (COLORREF)0x0000ff00);//绿色
		}	
	}

	//全部通用输出
	CRect l_rectBtnAll;
	l_rectBtnAll.left = m_ptGenOut.x + iLampSpace*8;
	l_rectBtnAll.top = m_ptGenOut.y + m_nFontHeight;
	l_rectBtnAll.right = l_rectBtnAll.left + 4*m_nFontHeight;
	l_rectBtnAll.bottom = l_rectBtnAll.top + m_rtLamp.Height();
	m_rtBtnGenAllOut = l_rectBtnAll;
	MemDC.Rectangle(l_rectBtnAll);
	MemDC.FillSolidRect(l_rectBtnAll, (COLORREF)0x0000ff00);
	MemDC.TextOut(l_rectBtnAll.left*1.02, l_rectBtnAll.top*1.06, "全部通用输出");

	//急停
	CRect l_rectBtnEmgStop;
	l_rectBtnEmgStop.left = m_ptGenOut.x + iLampSpace*11;
	l_rectBtnEmgStop.top = m_ptGenOut.y + m_nFontHeight;
	l_rectBtnEmgStop.right = l_rectBtnEmgStop.left + 4*m_nFontHeight;
	l_rectBtnEmgStop.bottom = l_rectBtnEmgStop.top + m_rtLamp.Height();
	m_rtBtnEmgStop = l_rectBtnEmgStop;
	MemDC.Rectangle(l_rectBtnEmgStop);
	MemDC.FillSolidRect(l_rectBtnEmgStop, (COLORREF)0x0000ff00);
	MemDC.TextOut(l_rectBtnEmgStop.left*1.02, l_rectBtnEmgStop.top*1.06, "  急    停");

	//依次输出
	CRect l_rectBtnGenSerOut;
	l_rectBtnGenSerOut.left = m_ptGenOut.x + iLampSpace*14;
	l_rectBtnGenSerOut.top = m_ptGenOut.y + m_nFontHeight;
	l_rectBtnGenSerOut.right = l_rectBtnGenSerOut.left + 4*m_nFontHeight;
	l_rectBtnGenSerOut.bottom = l_rectBtnGenSerOut.top + m_rtLamp.Height();
	m_rtBtnGenSerOut = l_rectBtnGenSerOut;
	MemDC.Rectangle(l_rectBtnGenSerOut);
	MemDC.FillSolidRect(l_rectBtnGenSerOut, (COLORREF)0x0000ff00);
	MemDC.TextOut(l_rectBtnGenSerOut.left*1.02, l_rectBtnGenSerOut.top*1.06, "通用依次输出");
	

	//扩展输入
	for(i=0; i<2; i++)
	{
		for(int j=0; j<16; j++)
		{
			CRect l_rect(&m_rtLamp);						 //确定矩形区域
			l_rect.left = m_ptExtIn.x + iLampSpace*j;
			l_rect.top = m_ptExtIn.y + m_nFontHeight + i*(m_rtLamp.Height() + m_nNumHeight);
			l_rect.right = l_rect.left + m_rtLamp.Width();
			l_rect.bottom = l_rect.top + m_rtLamp.Height();
			m_rtExtIN[i*16+j] = l_rect;						 //将矩形对象存入数组
			MemDC.Rectangle(l_rect);						 //向内存DC中画矩形
		}
	}
	for(i=2; i<3; i++)
	{
		for(int j=0; j<8; j++)
		{
			CRect l_rect(&m_rtLamp);						 //确定矩形区域
			l_rect.left = m_ptExtIn.x + iLampSpace*j;
			l_rect.top = m_ptExtIn.y + m_nFontHeight + i*(m_rtLamp.Height() + m_nNumHeight);
			l_rect.right = l_rect.left + m_rtLamp.Width();
			l_rect.bottom = l_rect.top + m_rtLamp.Height();
			m_rtExtIN[i*16+j] = l_rect;							 //将矩形对象存入数组
			MemDC.Rectangle(l_rect);						 //向内存DC中画矩形
		}
	}
	//填充颜色
	for(i=0; i<5; i++)
	{
		for(int j=0; j<8; j++)
		{
			int iRes = (m_iFlagExtIN[i] & (1<<j) )>>j;
			if (0==iRes)					 
			{
				MemDC.FillSolidRect(m_rtExtIN[i*8+j], (COLORREF)0x000000ff);//红色
			}
			else
			{
				MemDC.FillSolidRect(m_rtExtIN[i*8+j], (COLORREF)0x0000ff00);//绿色
			}	
		}
	}
	
	//限位
	for(i=0; i<1; i++)
	{
		for(int j=0; j<12; j++)
		{
			CRect l_rect(&m_rtLamp);						 //确定矩形区域
			l_rect.left = m_ptLmitBit.x + iLampSpace*j;
			l_rect.top = m_ptLmitBit.y + m_nFontHeight;
			l_rect.right = l_rect.left + m_rtLamp.Width();
			l_rect.bottom = l_rect.top + m_rtLamp.Height();
			m_rtLmtBit[j] = l_rect;							 //将矩形对象存入数组
			MemDC.Rectangle(l_rect);						 //向内存DC中画矩形
		}
	}
	//填充颜色
	for(i=0; i<12; i++)
	{
		if (TRUE == m_bFlagLmtBit[i])						   //查看当前限位状态
		{
			MemDC.FillSolidRect(m_rtLmtBit[i], (COLORREF)0x000000ff);//红色
		}
		else
		{
			MemDC.FillSolidRect(m_rtLmtBit[i], (COLORREF)0x0000ff00);//绿色
		}
	}

	//扩展输出
	for(i=0; i<2; i++)
	{
		for(int j=0; j<12; j++)
		{
			CRect l_rect(&m_rtLamp);						 //确定矩形区域
			l_rect.left = m_ptExtOut.x + iLampSpace*j;
			l_rect.top = m_ptExtOut.y + m_nFontHeight + i*(m_rtLamp.Height() + m_nNumHeight);
			l_rect.right = l_rect.left + m_rtLamp.Width();
			l_rect.bottom = l_rect.top + m_rtLamp.Height();
			m_rtExtOUT[i*12+j] = l_rect;					 //将矩形对象存入数组
			MemDC.Rectangle(l_rect);						 //向内存DC中画矩形
		}
	}
	//填充颜色
	for(i=0; i<3; i++)
	{
		for(int j=0; j<8; j++)
		{
			int iRes = (m_iFlagExtOUT[i] & (1<<j) )>>j;
			if (0==iRes)					 
			{
				MemDC.FillSolidRect(m_rtExtOUT[i*8+j], (COLORREF)0x000000ff);//红色
			}
			else
			{
				MemDC.FillSolidRect(m_rtExtOUT[i*8+j], (COLORREF)0x0000ff00);//绿色
			}	
		}
	}

	//全部扩展输出
	CRect l_rectBtnExtAll;
	l_rectBtnExtAll.left = m_ptExtOut.x + iLampSpace*12;
	l_rectBtnExtAll.top = m_ptExtOut.y + m_nFontHeight;
	l_rectBtnExtAll.right = l_rectBtnExtAll.left + 4*m_nFontHeight;
	l_rectBtnExtAll.bottom = l_rectBtnExtAll.top + m_rtLamp.Height();
	m_rtBtnExtAllOut = l_rectBtnExtAll;
	MemDC.Rectangle(l_rectBtnExtAll);
	MemDC.FillSolidRect(l_rectBtnExtAll, (COLORREF)0x0000ff00);
	MemDC.TextOut(l_rectBtnExtAll.left, l_rectBtnExtAll.top*1.02, " 全部扩展输出");

	//扩展依次输出
	CRect l_rectBtnExtSerOut;
	l_rectBtnExtSerOut.left = m_ptExtOut.x + iLampSpace*12;
	l_rectBtnExtSerOut.top = m_ptExtOut.y + m_nFontHeight + m_rtLamp.Height() + m_nNumHeight;
	l_rectBtnExtSerOut.right = l_rectBtnExtSerOut.left + 4*m_nFontHeight;
	l_rectBtnExtSerOut.bottom = l_rectBtnExtSerOut.top + m_rtLamp.Height();
	m_rtBtnExtSerOut = l_rectBtnExtSerOut;
	MemDC.Rectangle(l_rectBtnExtSerOut);
	MemDC.FillSolidRect(l_rectBtnExtSerOut, (COLORREF)0x0000ff00);
	MemDC.TextOut(l_rectBtnExtSerOut.left, l_rectBtnExtSerOut.top*1.02, " 扩展依次输出");
	
	//将内存DC中的内容显示到客户区中
	dc.BitBlt(0,0,m_rect.Width(),m_rect.Height(),&MemDC,0,0,SRCCOPY);
	//释放资源
	MemDC.SelectObject(&pOldFont);
	MemDC.DeleteDC();
	MemBitmap.DeleteObject();
}

void CITestv3Dlg::OnTimer(UINT nIDEvent) 
{
	//监控输入输出及限位信号
	GetExtInStatus();
	GetLmtBit();
	GetGenOutStatus();
	GetExtOutStatus();
	GetGenInStatus();	
	CDialog::OnTimer(nIDEvent);
}

void CITestv3Dlg::GetGenInStatus()
{
	//获取通用输入信号，八位一组，返回一个0~255之间的值
	char l_cInLight[80];
	int iValue;
	m_DMCWin.Command("MG_TI0", l_cInLight, sizeof(l_cInLight));
	iValue = atoi(l_cInLight);
	m_iFlagGenIN = iValue;
	if (m_iLastGenIN!=m_iFlagGenIN)	 
	{
		for(int i=0; i<1; i++)
		{
			for(int j=0; j<8; j++)
			{
				int iRes = (m_iFlagGenIN & (1<<j) )>>j;
				if (0==iRes)	
				{
					InvalidateRect(m_rtGenIN[j]);
				}
				else
				{
					InvalidateRect(m_rtGenIN[j]);
				}	
			}
		}
	}
	
	m_iLastGenIN = m_iFlagGenIN;
}

void CITestv3Dlg::GetExtInStatus()
{
	//获取扩展输入信号，八位一组，返回一个0~255之间的值
	char l_cExtInLight[80];			
	int iValue;
	for(int num=5; num<10; num++)
	{
		char cCommand[20];
		sprintf(cCommand, "MG_TI%d", num);
		m_DMCWin.Command(cCommand, l_cExtInLight, sizeof(l_cExtInLight));
		iValue = atoi(l_cExtInLight);
		m_iFlagExtIN[num-5] =iValue;
	}
	for(int i=0; i<5; i++)
	{
		if (m_iLastExtIN[i]!=m_iFlagExtIN[i]) 
		{
			for(int j=0; j<8; j++)
			{
				int iRes = (m_iFlagExtIN[i] & (1<<j) )>>j;
				if (0==iRes)					 
				{
					InvalidateRect(m_rtExtIN[i*8+j]);
				}
				else
				{
					InvalidateRect(m_rtExtIN[i*8+j]);
				}	
			}
		}	
	}

	for(i=0; i<5; i++)
	{
		m_iLastExtIN[i] = m_iFlagExtIN[i];
	}
}

void CITestv3Dlg::GetLmtBit()
{
	//获取限位信号
	char szLmtBit[80];
	memset(szLmtBit, 0, sizeof(szLmtBit));
	
	for(int i=0; i<12; i++)
	{
		switch (i)
		{
		case 0:
			m_DMCWin.Command("MG_LFX", szLmtBit, sizeof(szLmtBit));
			break;
		case 1:
			m_DMCWin.Command("MG_LRX", szLmtBit, sizeof(szLmtBit));
			break;
		case 2:
			m_DMCWin.Command("MG_HMX", szLmtBit, sizeof(szLmtBit));
			break;
		case 3:
			m_DMCWin.Command("MG_LFY", szLmtBit, sizeof(szLmtBit));
			break;
		case 4:
			m_DMCWin.Command("MG_LRY", szLmtBit, sizeof(szLmtBit));
			break;
		case 5:
			m_DMCWin.Command("MG_HMY", szLmtBit, sizeof(szLmtBit));
			break;
		case 6:
			m_DMCWin.Command("MG_LFZ", szLmtBit, sizeof(szLmtBit));
			break;
		case 7:
			m_DMCWin.Command("MG_LRZ", szLmtBit, sizeof(szLmtBit));
			break;
		case 8:
			m_DMCWin.Command("MG_HMZ", szLmtBit, sizeof(szLmtBit));
			break;
		case 9:
			m_DMCWin.Command("MG_LFW", szLmtBit, sizeof(szLmtBit));
			break;
		case 10:
			m_DMCWin.Command("MG_LRW", szLmtBit, sizeof(szLmtBit));
			break;
		case 11:
			m_DMCWin.Command("MG_HMW", szLmtBit, sizeof(szLmtBit));
			break;
		default:	break;
		}
		if (0==atoi(szLmtBit))	
		{
			m_bFlagLmtBit[i] = TRUE;
		}
		else
		{
			m_bFlagLmtBit[i] = FALSE;
		}
		memset(szLmtBit, 0, sizeof(szLmtBit));
	}
	for(i=0; i<12; i++)
	{
		if (m_bLastLmtBit[i]!=m_bFlagLmtBit[i]) 
		{
			InvalidateRect(m_rtLmtBit[i]);
		}
	}
	
	for(i=0; i<12; i++)
	{
		m_bLastLmtBit[i] = m_bFlagLmtBit[i];
	}
}

void CITestv3Dlg::GetGenOutStatus()
{
	//获取通用输出信号，八位一组，返回一个0~255之间的值
	char l_cOutLight[80];
	int iValue;
	m_DMCWin.Command("MG_OP0", l_cOutLight, sizeof(l_cOutLight));
	iValue = atoi(l_cOutLight);
	m_iFlagGenOUT =iValue; 
	for(int i=1; i<2; i++)
	{
		if (m_iLastGenOUT!=m_iFlagGenOUT) 
		{
			for(int j=0; j<8; j++)
			{
				int iRes = (m_iFlagGenOUT & (1<<j) )>>j;
				if (1==iRes)				
				{
					InvalidateRect(m_rtGenOUT[j]);
				}
				else
				{
					InvalidateRect(m_rtGenOUT[j]);
				}	
			}
		}
	}
	m_iLastGenOUT = m_iFlagGenOUT;
}

void CITestv3Dlg::GetExtOutStatus()
{
	//获取扩展输出信号，十六位一组，返回一个0~65535之间的值
	char l_cExtOutLight[16];
	int iValue;
	m_DMCWin.Command("MG_OP1", l_cExtOutLight, sizeof(l_cExtOutLight));
	iValue = atoi(l_cExtOutLight);
	m_iFlagExtOUT[0] = iValue ^ 255;			//取低八位
	m_iFlagExtOUT[1] = (iValue ^ 65280) >> 8;	//取高八位
	
	
	m_DMCWin.Command("MG_OP2", l_cExtOutLight, sizeof(l_cExtOutLight));
	iValue = atoi(l_cExtOutLight);
	m_iFlagExtOUT[2] = iValue ^ 255;	//取低八位

	for(int i=0; i<3; i++)
	{
		if (m_iLastExtOUT[i]!=m_iFlagExtOUT[i]) 
		{
			for(int j=0; j<8; j++)
			{
				int iRes = (m_iFlagExtOUT[i] & (1<<j) )>>j;
				if (!iRes)					 
				{
					InvalidateRect(m_rtExtOUT[i*8+j]);
				}
				else
				{
					InvalidateRect(m_rtExtOUT[i*8+j]);
				}	
			}
		}
	}
	for(i=0; i<3; i++)
	{
		m_iLastExtOUT[i] = m_iFlagExtOUT[i];
	}
}

void CITestv3Dlg::OnLButtonDown(UINT nFlags, CPoint point) 
{
	//判断是否点击通用输出按钮
	for(int i=0; i<8; i++)
	{
		if (m_rtGenOUT[i].PtInRect(point)) 
		{
			char szBuffer[80];
			sprintf(szBuffer, "OB %d,1-@OUT[%d]", i+1, i+1);
			m_DMCWin.Command(szBuffer);	
			InvalidateRect(m_rtGenOUT[i]);
		}
	}
	//判断是否点击扩展输出按钮
	for(i=0; i<24; i++)
	{
		if (m_rtExtOUT[i].PtInRect(point)) 
		{
			CString str;
			str.Format("OB %d,1-@OUT[%d]", (i+17), (i+17));
			m_DMCWin.Command((LPSTR)(LPCSTR)str);
			InvalidateRect(m_rtExtOUT[i]);
		}
	}
	//判断是否点击全部通用输出按钮
	if (m_rtBtnGenAllOut.PtInRect(point)) 
	{
		for(int i=0; i<8; i++)
		{
			char szBuffer[80];
			sprintf(szBuffer, "OB %d,1-@OUT[%d]", i+1, i+1);
			m_DMCWin.Command(szBuffer);	
			InvalidateRect(m_rtExtOUT[i]);
		}
	}
	//判断是否点击急停按钮
	if(m_rtBtnEmgStop.PtInRect(point))
	{
		m_DMCWin.Command("AB");
	}
	//判断是否点击通用依次输出按钮
	if(m_rtBtnGenSerOut.PtInRect(point))
	{
		//创建线程
		m_hThreadOne = CreateThread(NULL, 100, ThreadFunOne, (void*)this, CREATE_SUSPENDED, NULL);
		SetThreadPriority(m_hThreadOne, THREAD_PRIORITY_NORMAL);
		ResumeThread(m_hThreadOne);
	}
	//判断是否点击全部扩展输出按钮
	if (m_rtBtnExtAllOut.PtInRect(point)) 
	{
		for(int i=0; i<24; i++)
		{
			CString str;
			str.Format("OB %d,1-@OUT[%d]", (i+17), (i+17));
			m_DMCWin.Command((LPSTR)(LPCSTR)str);
			InvalidateRect(m_rtExtOUT[i]);
		}
	}
	//判断是否点击扩展依次输出按钮
	if(m_rtBtnExtSerOut.PtInRect(point))
	{
		//创建线程
		m_hThreadTwo = CreateThread(NULL, 100, ThreadFunTwo, (void*)this, CREATE_SUSPENDED, NULL);
		SetThreadPriority(m_hThreadTwo, THREAD_PRIORITY_NORMAL);
		ResumeThread(m_hThreadTwo);
	}
	CDialog::OnLButtonDown(nFlags, point);
}

BOOL CITestv3Dlg::DestroyWindow() 
{
	// TODO: Add your specialized code here and/or call the base class
	delete(m_rtLamp);
	return CDialog::DestroyWindow();
}

DWORD CITestv3Dlg::ThreadFunOne(LPVOID lpParam)
{
	CITestv3Dlg *pDlg = (CITestv3Dlg*)lpParam;
	for(int i=0; i<8; i++)
	{
		char szBuffer[80];
		sprintf(szBuffer, "OB %d,1-@OUT[%d]", i+1, i+1);
		pDlg->m_DMCWin.Command(szBuffer);	
		Sleep(500);
	}
	return 0;
}

DWORD CITestv3Dlg::ThreadFunTwo(LPVOID lpParam)
{
	CITestv3Dlg *pDlg = (CITestv3Dlg*)lpParam;
	for(int i=0; i<24; i++)
	{
		char szBuffer[80];
		sprintf(szBuffer, "OB %d,1-@OUT[%d]", i+17, i+17);
		pDlg->m_DMCWin.Command(szBuffer);	
		Sleep(500);
		sprintf(szBuffer, "OB %d,1-@OUT[%d]", i+17, i+17);
		pDlg->m_DMCWin.Command(szBuffer);	
		Sleep(500);
	}
	return 0;
}