// iSingleAxisMotionDlg.cpp : implementation file
//

#include "stdafx.h"
#include "iSingleAxisMotion.h"
#include "iSingleAxisMotionDlg.h"

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
// CISingleAxisMotionDlg dialog
int logic = 1;
USHORT g_nController = 1;
CDMCWin g_Controller;
long g_lRc;
CISingleAxisMotionDlg::CISingleAxisMotionDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CISingleAxisMotionDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CISingleAxisMotionDlg)
	m_bLogic = TRUE;	
	m_lSpeed = 10000;
	m_lSacc = 5000;
	m_lSdec = 5000;
	m_nSpeedst = 0;
	m_nAxis = 0;
	m_lPulse = 0;
	m_iRadioAxis = 0;
	m_iActionPoint = 0;
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CISingleAxisMotionDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CISingleAxisMotionDlg)
	DDX_Text(pDX, IDC_EDTSPEED, m_lSpeed);
	DDX_Text(pDX, IDC_EDTSPEEDACC, m_lSacc);
	DDX_Text(pDX, IDC_EDTSPEEDEC, m_lSdec);
	DDX_Text(pDX, IDC_EDIT_PULSE, m_lPulse);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CISingleAxisMotionDlg, CDialog)
	//{{AFX_MSG_MAP(CISingleAxisMotionDlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_DESTROY()
	ON_WM_TIMER()
	ON_BN_CLICKED(IDC_BTNZERO, OnBtnPosZero)
	ON_BN_CLICKED(IDC_BTNEMGSTOP, OnBtnEmgStop)
	ON_BN_CLICKED(IDC_BTNSTOP, OnBtnStop)
	ON_BN_CLICKED(IDC_RADIO_CMOVE, OnRadioCmove)
	ON_BN_CLICKED(IDC_RADIO_ACTIONST, OnRadioActionst)
	ON_BN_CLICKED(IDC_BTNEXC, OnBtnDo)
	ON_BN_CLICKED(IDC_RADIO_X_AXS, OnRadioXAxs)
	ON_BN_CLICKED(IDC_RADIO_Y_AXS, OnRadioYAxs)
	ON_BN_CLICKED(IDC_RADIO_Z_AXS, OnRadioZAxs)
	ON_BN_CLICKED(IDC_RADIO_W_AXS, OnRadioWAxs)
	ON_BN_CLICKED(IDC_CHECK_LOGIC, OnCheckLogic)
	ON_BN_CLICKED(IDC_BTNRETZERO, OnBtnretzero)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CISingleAxisMotionDlg message handlers

BOOL CISingleAxisMotionDlg::OnInitDialog()
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
	//���Ի���ӱ���
	this->SetWindowText("�����˶�Ver1.0@PowerLand");
	//��ʼ���ؼ�
	InitCtrl();
	//���ö�ʱ��
	SetTimer(1, 100, NULL);
	//ע�������
	CDMCWinRegistry DMCWinRegistry;//ע����
	GALILREGISTRY galilregistry;//ע����Ϣ��ר�����ݽṹ��
	if (DMCWinRegistry.GetGalilRegistryInfo(g_nController, &galilregistry) == DMCERROR_CONTROLLER)
	{
		//��ע����Ϣ
		memset(&galilregistry,0,sizeof(galilregistry));
		CHAR    Model[16]="DMC-21x3/2";	
		memcpy(galilregistry.szModel,Model,16);
		galilregistry.ulTimeout = 5000;
		galilregistry.usCommPort = 5000;
		galilregistry.fControllerType = 4;//4:����  1������
		CHAR    PNPHardwareKey[64] = "192.168.1.21";
		memcpy(galilregistry.szPNPHardwareKey,PNPHardwareKey,64);
		
		DMCWinRegistry.AddGalilRegistry(&galilregistry,&g_nController);
	}
	//�򿪿�����
	g_lRc = g_Controller.Open(g_nController, GetSafeHwnd());
	if (0 != g_lRc) 
	{
		char szBuffer[80];
		sprintf(szBuffer, "��������ʧ��%d", g_lRc);
		MessageBox(szBuffer, "�����˶�Ver1.0@PowerLand");
	}
	
	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CISingleAxisMotionDlg::OnSysCommand(UINT nID, LPARAM lParam)
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

void CISingleAxisMotionDlg::OnPaint() 
{
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
}

// The system calls this to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CISingleAxisMotionDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

void CISingleAxisMotionDlg::OnDestroy() 
{
	CDialog::OnDestroy();
	//�رտ��������ͷ���Դ
	long l_lRes;
	l_lRes = g_Controller.Close();
	if(DMCNOERROR != l_lRes)
	{
		char szBuffer[80];
		sprintf(szBuffer, "�������ر�ʧ��%d", l_lRes);
		MessageBox(szBuffer);
	}
}

void CISingleAxisMotionDlg::OnTimer(UINT nIDEvent) 
{
	//��ȡ��ʾ״̬��λ��
	CString string;
	long position = GetPosition( );
	string.Format("��ǰλ�ã�%ld", position );
	GetDlgItem( IDC_STATIC_POS )->SetWindowText( string );
	
	int status = GetStatus( );
	string.Format("״ֵ̬��0%x %s", status, status? "������":"�������" );
	GetDlgItem( IDC_STATIC_STATUS )->SetWindowText( string );
	if (status) 
	{
		((CButton*)GetDlgItem( IDC_BTNEXC))->EnableWindow(TRUE);
	}
	CDialog::OnTimer(nIDEvent);
}

long CISingleAxisMotionDlg::GetPosition()
{
	//��ȡλ��
	long lCurntPos;
	char szCurnPos[80];
	char cCmd[80];
	switch(m_nAxis) 
	{
		case 0:		sprintf(cCmd, "TPX", 0);		break;
		case 1:		sprintf(cCmd, "TPY", 0);		break;
		case 2:		sprintf(cCmd, "TPZ", 0);		break;
		case 3:		sprintf(cCmd, "TPW", 0);		break;
		default:	break;
	}
	g_Controller.Command(cCmd, szCurnPos, sizeof(szCurnPos));
	lCurntPos = atoi(szCurnPos);
	return lCurntPos;
}

int CISingleAxisMotionDlg::GetStatus()
{
	//��ȡ����״̬
	int iStatus = 0;
	char szStatus[80];
	char cCmd[80];
	switch(m_nAxis) 
	{
		case 0:		sprintf(cCmd, "MG_BGX", 0);		break;
		case 1:		sprintf(cCmd, "MG_BGY", 0);		break;
		case 2:		sprintf(cCmd, "MG_BGZ", 0);		break;
		case 3:		sprintf(cCmd, "MG_BGW", 0);		break;
		default:	break;
	}
	g_Controller.Command(cCmd, szStatus, sizeof(szStatus));
	iStatus = atoi(szStatus);
	return iStatus;
}

void CISingleAxisMotionDlg::OnBtnPosZero() 
{
	//����
	char szRes[80];
	char cCmd[80];
	switch(m_nAxis) 
	{
	case 0:		sprintf(cCmd, "DP%d", 0);		break;
	case 1:		sprintf(cCmd, "DP,%d", 0);		break;
	case 2:		sprintf(cCmd, "DP,,%d", 0);		break;
	case 3:		sprintf(cCmd, "DP,,,%d", 0);	break;
	default:	break;
	}
	g_Controller.Command(cCmd, szRes, sizeof(szRes));
	CString str;
	str.Format("��ǰλ��:%d", GetPosition());
	((CWnd*)GetDlgItem(IDC_STATIC_POS))->SetWindowText(str);
}

void CISingleAxisMotionDlg::OnBtnEmgStop( ) 
{
	//��ͣ
	g_Controller.Command("AB");
	((CButton*)GetDlgItem(IDC_BTNEXC))->EnableWindow(TRUE);
}

void CISingleAxisMotionDlg::InitCtrl()
{
	//��ʼ���ؼ�״̬
	((CButton*)GetDlgItem(IDC_RADIO_X_AXS))->SetCheck(BST_CHECKED);
	((CButton*)GetDlgItem(IDC_RADIO_CMOVE))->SetCheck(BST_CHECKED);
	((CButton*)GetDlgItem(IDC_CHECK_LOGIC))->SetCheck(BST_CHECKED);
	GetDlgItem( IDC_CHECK_LOGIC )->SetWindowText( m_bLogic?"�߼�������":"�߼����򣺷�");
	UpdateData(FALSE);
}

void CISingleAxisMotionDlg::OnBtnStop() 
{
	//ֹͣ
	g_Controller.Command("ST");
	((CButton*)GetDlgItem( IDC_BTNEXC))->EnableWindow(TRUE);
}

void CISingleAxisMotionDlg::UpdateControl()
{
	GetDlgItem( IDC_CHECK_LOGIC )->SetWindowText( m_bLogic?"�߼�������":"�߼����򣺷�");
}

void CISingleAxisMotionDlg::OnCheckLogic()
{
	//�߼�����
	m_bLogic = !m_bLogic;
	UpdateData( TRUE );
	UpdateControl();
	
}

void CISingleAxisMotionDlg::OnRadioCmove() 
{
	// �����˶�
	if (IDC_RADIO_CMOVE == GetCheckedRadioButton(IDC_RADIO_ACTIONST,IDC_RADIO_CMOVE))
	{
		m_iActionPoint = 0;
	}
}

void CISingleAxisMotionDlg::OnRadioActionst() 
{
	//�㶯
	if (IDC_RADIO_ACTIONST == GetCheckedRadioButton(IDC_RADIO_ACTIONST,IDC_RADIO_CMOVE))
	{
		m_iActionPoint = 1;
	}
}

void CISingleAxisMotionDlg::OnBtnDo() 
{
	//���ղ���
	try{
		if( !UpdateData(TRUE) )
			throw "";
	}
	catch( char * ){
		return;
	}

	if (!m_bLogic) 
	{
		m_lSpeed = -m_lSpeed;
		m_lSacc	 = -m_lSacc;
		m_lSdec	 = -m_lSdec;
		m_lPulse = -m_lPulse;
	}
	//�Ѿ����˶���
	if (1 == GetStatus()) 
		return;
	char cCmd[80];
	char szRes[80];
	if (m_iActionPoint) 
	{
		if (0 == m_lPulse)
		{
			MessageBox("������㶯ֵ!", "ע��");
			return;
		}
		//�Ѿ����˶���
		if (1 == GetStatus()) 
			return;
		
		switch(m_nAxis) 
		{
			case 0:	sprintf(cCmd, "SH;PR%d;SP%d;AC%d;DC%d;BGX", m_lPulse, m_lSpeed, m_lSacc, m_lSdec);	break;
			case 1:	sprintf(cCmd, "SH;PR,%d;SP,%d;AC,%d;DC,%d;BGY", m_lPulse, m_lSpeed, m_lSacc, m_lSdec);	break;
			case 2:	sprintf(cCmd, "SH;PR,,%d;SP,,%d;AC,,%d;DC,,%d;BGZ", m_lPulse, m_lSpeed, m_lSacc, m_lSdec);	break;
			case 3:	sprintf(cCmd, "SH;PR,,,%d;SP,,,%d;AC,,,%d;DC,,,%d;BGW", m_lPulse, m_lSpeed, m_lSacc, m_lSdec);	break;
			default:		break;
		}
	}
	else
	{
		//���м��ٶȣ����м��ٶ�
		switch(m_nAxis) 
		{
			case 0:	sprintf(cCmd, "SH;JG%d;AC%d;DC%d;BGX", m_lSpeed, m_lSacc, m_lSdec);	break;
			case 1:	sprintf(cCmd, "SH;JG,%d;AC,%d;DC,%d;BGY", m_lSpeed, m_lSacc, m_lSdec);	break;
			case 2:	sprintf(cCmd, "SH;JG,,%d;AC,,%d;DC,,%d;BGZ", m_lSpeed, m_lSacc, m_lSdec);	break;
			case 3:	sprintf(cCmd, "SH;JG,,,%d;AC,,,%d;DC,,,%d;BGW", m_lSpeed, m_lSacc, m_lSdec);	break;
			default:		break;
		}
	}	
	
	//��忨��������
	g_Controller.Command(cCmd, szRes, sizeof(szRes));
	((CButton*)GetDlgItem(IDC_BTNEXC))->EnableWindow(FALSE);
}

void CISingleAxisMotionDlg::OnRadioXAxs() 
{
	//ѡ��X��
	if (0 != GetCheckedRadioButton(IDC_RADIO_X_AXS, IDC_RADIO_W_AXS)) 
	{
		m_nAxis = 0;
	}	
}

void CISingleAxisMotionDlg::OnRadioYAxs() 
{
	//ѡ��Y��
	if ( 0 != GetCheckedRadioButton(IDC_RADIO_X_AXS, IDC_RADIO_W_AXS)) 
	{
		m_nAxis = 1;
	}	
}

void CISingleAxisMotionDlg::OnRadioZAxs() 
{
	//ѡ��Z��
	if ( 0 != GetCheckedRadioButton(IDC_RADIO_X_AXS, IDC_RADIO_W_AXS)) 
	{
		m_nAxis = 2;
	}	
}

void CISingleAxisMotionDlg::OnRadioWAxs() 
{
	//ѡ��W��
	if (0 != GetCheckedRadioButton(IDC_RADIO_X_AXS, IDC_RADIO_W_AXS)) 
	{
		m_nAxis = 3;
	}	
}

void CISingleAxisMotionDlg::OnBtnretzero() 
{
	switch(m_nAxis) 
	{
		case 0:	g_Controller.Command("HM;BGX");	break;
		case 1:	g_Controller.Command("HM;BGY");	break;
		case 2:	g_Controller.Command("HM;BGZ");	break;
		case 3:	g_Controller.Command("HM;BGW");	break;
		default:		break;
	}
	
}
