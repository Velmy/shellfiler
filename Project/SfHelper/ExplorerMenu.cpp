#include "pch.h"
#include "ExplorerMenu.h"

//=========================================================================================
// �@�@�\�F�R���X�g���N�^
// ���@���F�Ȃ�
// �߂�l�F�Ȃ�
//=========================================================================================
ExplorerMenu::ExplorerMenu()
{
	m_hwnd = NULL;
	m_hMenu = NULL;
	m_wchPath = NULL;
	m_pMalloc = NULL;
	m_pShellFolder = NULL;
	m_pContextMenu = NULL;
	m_pContextMenu2 = NULL;
	m_pidlMain = NULL;
	m_pidlNextItem = NULL;
}

//=========================================================================================
// �@�@�\�F�f�X�g���N�^
// ���@���F�Ȃ�
// �߂�l�F�Ȃ�
//=========================================================================================
ExplorerMenu::~ExplorerMenu()
{
	if(m_hMenu != NULL) {
		DestroyMenu(m_hMenu);
		m_hMenu = NULL;
	}
	if(m_pContextMenu2 != NULL) {
		m_pContextMenu2->Release();
		m_pContextMenu2 = NULL;
	}
	if(m_pContextMenu != NULL) {
		m_pContextMenu->Release();
		m_pContextMenu = NULL;
	}
	if(m_pShellFolder != NULL) {
		m_pShellFolder->Release();
		m_pShellFolder = NULL;
	}
	if (m_wchPath != NULL) {
		delete[] m_wchPath;
		m_wchPath = NULL;
	}
	if(m_pMalloc != NULL) {
		if(m_pidlMain != NULL) {
			m_pMalloc->Free(m_pidlMain);
			m_pidlMain = NULL;
		}
		if(m_pidlNextItem != NULL) {
			m_pMalloc->Free(m_pidlNextItem);
			m_pidlNextItem = NULL;
		}
		m_pMalloc->Release();
		m_pMalloc = NULL;
	}
}

//=========================================================================================
// �@�@�\�F�G�N�X�v���[���̃��j���[�ł̃��b�Z�[�W����������
// ���@���F[in]hwnd     �E�B���h�E�n���h��
// �@�@�@�@[in]message  �E�B���h�E���b�Z�[�W
// �@�@�@�@[in]wParam   WPARAM�l
// �@�@�@�@[in]lParam   LPARAM�l
// �߂�l�F���b�Z�[�W�����������Ƃ�TRUE
//=========================================================================================
BOOL ExplorerMenu::HandleMenuMsg(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	// WM_INITMENUPOPUP
	// WM_DRAWITEM
	// WM_MEASUREITEM
	if (m_pContextMenu2 != NULL && hwnd == m_hwnd) {
		m_pContextMenu2->HandleMenuMsg(message, wParam, lParam);
		return TRUE;
	} else {
		return FALSE;
	}
}

//=========================================================================================
// �@�@�\�F�G�N�X�v���[���̃��j���[���쐬����
// ���@���F[in]hwnd     �\������E�B���h�E�̃n���h��
// �@�@�@�@[in]wchPath  �Ώۃt�@�C���̃p�X��
// �߂�l�F���j���[�̃n���h���iNULL:���s�j
//=========================================================================================
HMENU ExplorerMenu::CreateExplorerMenu(HWND hwnd, const WCHAR* wchPath)
{
	HRESULT hRes;
	m_hwnd = hwnd;

	m_wchPath = new WCHAR[wcslen(wchPath) + 1];
#pragma warning (disable:4996)
	wcscpy(m_wchPath, wchPath);

	// ShellFolder�C���^�[�t�F�[�X���擾
	hRes = SHGetMalloc(&m_pMalloc);
	if(FAILED(hRes)) {
		return NULL;
	}
	hRes = SHGetDesktopFolder(&m_pShellFolder);
	if(FAILED(hRes)) {
		return NULL;
	}

	// �ΏۃI�u�W�F�N�g��PIDL���擾
	ULONG ulAttr = 0;
	hRes = m_pShellFolder->ParseDisplayName(hwnd, NULL, m_wchPath, NULL, &m_pidlMain, &ulAttr);
	if(FAILED(hRes) || (m_pidlMain == NULL)) {
		return NULL;
	}
	UINT nCount = getItemCount(m_pidlMain);
	if(nCount == 0) {
		return NULL;
	}
	LPITEMIDLIST pidlItem = m_pidlMain;
	while(--nCount) {
		m_pidlNextItem = duplicateItem(m_pMalloc, pidlItem);
		if(m_pidlNextItem == NULL) {
			return NULL;
		}
		LPSHELLFOLDER psfNextFolder;
		hRes = m_pShellFolder->BindToObject(m_pidlNextItem, NULL, IID_IShellFolder, (void**)(&psfNextFolder));
		if(FAILED(hRes)) {
			return NULL;
		}
		m_pShellFolder->Release();
		m_pShellFolder = psfNextFolder;
		m_pMalloc->Free(m_pidlNextItem);
		m_pidlNextItem = NULL;
		pidlItem = getNextItem(pidlItem);
	}

	// �ΏۃI�u�W�F�N�g���擾
	LPCITEMIDLIST* ppidl = (LPCITEMIDLIST*)&pidlItem;
	hRes = m_pShellFolder->GetUIObjectOf(hwnd, 1, ppidl, IID_IContextMenu, NULL, (void**)(&m_pContextMenu));
	if(FAILED(hRes)) {
		return NULL;
	}
	hRes = m_pContextMenu->QueryInterface(IID_IContextMenu2, (void**)(&m_pContextMenu2));
	if(FAILED(hRes)) {
		return NULL;
	}

	// ���j���[���쐬
	m_hMenu = CreatePopupMenu();
	hRes = m_pContextMenu2->QueryContextMenu(m_hMenu, 0, 1, 0x7fff, CMF_EXPLORE);
	if(FAILED(hRes)) {
		return NULL;
	}

	return m_hMenu;
}

//=========================================================================================
// �@�@�\�F�G�N�X�v���[���̃��j���[���ڂ����s����
// ���@���F[in]nCmd  �R�}���h�̍���
// �߂�l�F���s�ɐ��������Ƃ�TRUE
//=========================================================================================
BOOL ExplorerMenu::ExecuteMenuItem(int nCmd)
{
	// ���j���[���ڂ����s
	HRESULT hRes;
	CMINVOKECOMMANDINFO ici;
	ici.cbSize			= sizeof(CMINVOKECOMMANDINFO);
	ici.fMask			= 0;
	ici.hwnd			= m_hwnd;
	ici.lpVerb			= (LPCSTR)MAKEINTRESOURCE(nCmd - 1);
	ici.lpParameters	= NULL;
	ici.lpDirectory		= NULL;
	ici.nShow			= SW_SHOWNORMAL;
	ici.dwHotKey		= 0;
	ici.hIcon			= NULL;
	hRes = m_pContextMenu->InvokeCommand(&ici);
	if(FAILED(hRes)) {
		return FALSE;
	}
	return TRUE;
}

//=========================================================================================
// �@�@�\�F�A�C�e��ID���X�g��ID�̐����v�Z����
// ���@���F[in]pidl	�A�C�e��ID���X�g�ւ̃|�C���^
// �߂�l�F�A�C�e��ID�̐�
//=========================================================================================
UINT ExplorerMenu::getItemCount(LPITEMIDLIST pidl)
{
	USHORT nLen;
	UINT nCount;

	nCount = 0;
	while((nLen = pidl->mkid.cb) != 0) {
		pidl = getNextItem(pidl);
		nCount++;
	}
	return nCount;
}

//=========================================================================================
// �@�@�\�F���̃A�C�e���𓾂�
// ���@���F[in]pidl	�A�C�e��ID���X�g�ւ̃|�C���^
// �߂�l�F���̃A�C�e���ւ̃|�C���^
//=========================================================================================
LPITEMIDLIST ExplorerMenu::getNextItem(LPITEMIDLIST pidl)
{
	USHORT nLen;

	if((nLen = pidl->mkid.cb) == 0) {
		return NULL;
	}

	return (LPITEMIDLIST)(((LPBYTE)pidl) + nLen);
}

//=========================================================================================
// �@�@�\�F�A�C�e��ID���X�g�̎��̃A�C�e���̃R�s�[�����
// ���@���F[in]pMalloc	IMalloc�C���^�t�F�[�X�ւ̃|�C���^
// �@�@�@�@[in]pidl     �A�C�e��ID���X�g�ւ̃|�C���^
// �߂�l�F�R�s�[���ꂽ�A�C�e��ID���܂�ITEMIDLIST�ւ̃|�C���^
//=========================================================================================
LPITEMIDLIST ExplorerMenu::duplicateItem(LPMALLOC pMalloc, LPITEMIDLIST pidl)
{
	USHORT nLen;
	LPITEMIDLIST pidlNew;

	nLen = pidl->mkid.cb;
	if(nLen == 0) {
		return NULL;
	}

	pidlNew = (LPITEMIDLIST)pMalloc->Alloc(nLen + sizeof(USHORT));
	if(pidlNew == NULL) {
		return NULL;
	}

	CopyMemory(pidlNew, pidl, nLen);
	*((USHORT*)(((LPBYTE)pidlNew) + nLen)) = 0;

	return pidlNew;
}
