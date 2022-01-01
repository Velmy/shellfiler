#include "pch.h"
#include "ExplorerMenu.h"


// �G���[�����������Ƃ�true
BOOL s_error = FALSE;

//=========================================================================================
// �@�@�\�F�G�N�X�v���[�����j���[������������
// ���@���F�Ȃ�
// �߂�l�F���C�u�����n���h��
//=========================================================================================
void* __stdcall InitializeExplorerMenu()
{
	ExplorerMenu* pExpMenu = new ExplorerMenu();
	return pExpMenu;
}

//=========================================================================================
// �@�@�\�F�G�N�X�v���[�����j���[���쐬����
// ���@���F[in]hExpMenu   ���C�u�����n���h��
// �@�@�@�@[in]hwnd       ���j���[��\������E�B���h�E
// �@�@�@�@[in]path       �\������t�@�C���̃p�X
// �߂�l�F���j���[�̃n���h��
//=========================================================================================
HMENU __stdcall ShowExplorerMenu(void* hExpMenu, HWND hwnd, const WCHAR* path)
{
	ExplorerMenu* pMenu = (ExplorerMenu*)hExpMenu;
	HMENU hPopup = pMenu->CreateExplorerMenu((HWND)hwnd, path);
	return hPopup;
}

//=========================================================================================
// �@�@�\�F���j���[���ڂ����s����
// ���@���F[in]hExpMenu   ���C�u�����n���h��
// �@�@�@�@[in]nCmd       ���s���郁�j���[���ڂ̍���
// �߂�l�F���s�ɐ��������Ƃ�true
//=========================================================================================
BOOL __stdcall ExecuteExplorerMenuItem(void* hExpMenu, LONG nCmd) 
{
	ExplorerMenu* pMenu = (ExplorerMenu*)hExpMenu;
	return pMenu->ExecuteMenuItem(nCmd);
}

//=========================================================================================
// �@�@�\�F�G�N�X�v���[�����j���[�̌�n�����s��
// ���@���F[in]hExpMenu   ���C�u�����n���h��
// �߂�l�F�Ȃ�
//=========================================================================================
void __stdcall DeleteExplorerMenu(void* hExpMenu)
{
	ExplorerMenu* pMenu = (ExplorerMenu*)hExpMenu;
	delete pMenu;
}

//=========================================================================================
// �@�@�\�F���j���[�\�����̃��b�Z�[�W�𒆌p����
// ���@���F[in]hExpMenu   ���C�u�����n���h��
// �@�@�@�@[in]hwnd       ���j���[��\�����̃E�B���h�E�̃n���h��
// �@�@�@�@[in]message    �E�B���h�E���b�Z�[�W
// �@�@�@�@[in]wParam     �E�B���h�E���b�Z�[�W�̃p�����[�^
// �@�@�@�@[in]lParam     �E�B���h�E���b�Z�[�W�̃p�����[�^
// �߂�l�F���b�Z�[�W�����������Ƃ�TRUE
//=========================================================================================
BOOL __stdcall HandleMenuMessage(void* hExpMenu, HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam) 
{
	ExplorerMenu* pMenu = (ExplorerMenu*)hExpMenu;
	return pMenu->HandleMenuMsg(hwnd, message, wParam, lParam);
}

//=========================================================================================
// �@�@�\�F�p�X���[�h�\���g��Ԃ�
// ���@���F�Ȃ�
// �߂�l�F�p�X���[�h�̃\���g
//=========================================================================================
int __stdcall GetPasswordSalt()
{
	int index[] = {
		 4, 24, 21, 16, 18, 11, 26, 19,  6, 20, 15, 30,  0,  3, 12,  9,
		14, 27, 29,  7, 22,  2, 10,  8, 13, 17,  1, 23, 31,  5, 25, 28
	};
	SYSTEMTIME systime;
	GetSystemTime(&systime);
	DWORD wMilliseconds = systime.wMilliseconds;

	DWORD org = 0;
	DWORD date = (systime.wYear - 2000) * 400 + (systime.wMonth - 1) * 32 + systime.wDay;
	DWORD pwkey = systime.wMilliseconds ^ 0x10305070;
	GetSystemTime(&systime);
	pwkey ^= 0x02040608;
	if (s_error) {
		date ^= 0x9182;
	}
	pwkey ^= wMilliseconds;
	org = (date << 16) ^ pwkey;

	DWORD result = 0;
	for (int i = 0; i < 32; i++) {
		result = result << 1;
		result |= (org >> index[i]) & 0x1;
	}

	return result;
}
