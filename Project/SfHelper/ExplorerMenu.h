#pragma once

//=========================================================================================
//	�N���X�F�G�N�X�v���[�������j���[
//=========================================================================================
class ExplorerMenu {
	// �e�ƂȂ�E�B���h�E�n���h��
	HWND m_hwnd;

	// �쐬�������j���[
	HMENU m_hMenu;

	// �ꎞ��Ɨp�̑Ώۃt�@�C���p�X��
	WCHAR* m_wchPath;

	// ���j���[��IMalloc�C���^�[�t�F�[�X
	LPMALLOC m_pMalloc;

	// ���j���[��IShellFolder�C���^�[�t�F�[�X
	LPSHELLFOLDER m_pShellFolder;

	// ���j���[��IContextMenu�C���^�[�t�F�[�X
	LPCONTEXTMENU m_pContextMenu;

	// ���j���[��IContextMenu2�C���^�[�t�F�[�X
	LPCONTEXTMENU2 m_pContextMenu2;

	// IDL�̍�Ɨp
	LPITEMIDLIST m_pidlMain;

	// IDL�̍�Ɨp
	LPITEMIDLIST m_pidlNextItem;

public:
	ExplorerMenu();
	~ExplorerMenu();
	BOOL HandleMenuMsg(HWND, UINT, WPARAM, LPARAM);
	HMENU CreateExplorerMenu(HWND hwnd, const WCHAR* wchPath);
	BOOL ExecuteMenuItem(int nCmd);
private:
	UINT getItemCount(LPITEMIDLIST);
	LPITEMIDLIST getNextItem(LPITEMIDLIST);
	LPITEMIDLIST duplicateItem(LPMALLOC, LPITEMIDLIST);
};
