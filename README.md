# RTD_Public

---

## 개요

### 프로젝트 소개

C9조 Nine to Nine의 RTD입니다.

저희가 만든 게임은 전략성이 가미된 타워디펜스 게임입니다.

넓은 개활지에서 적들이 지나다닐 경로를 직접 만들고 포탑을 지어서 적을 막는 방식으로 진행합니다.

---

## 게임 화면

우선 게임 화면에 대한 설명입니다.

### 시작 화면


![imaggsde](https://github.com/user-attachments/assets/0e50f484-e2b9-4aa4-b6c5-9bca98c9d53b)

게임의 시작화면은 다음과 같이 구성되어있습니다.

1.게임 타이틀 : 게임의 타이틀입니다.

2.게임 시작버튼 : 게임을 시작할 수 있는 버튼입니다.

3.게임 설명버튼 : 대략적인 게임의 설명이 적혀있습니다.

4.특성 버튼 : 회차플레이 요소인 특성 포인트를 사용할 수 있는 창을 띄웁니다.

![image](https://github.com/user-attachments/assets/727a5300-4de8-47d2-9bcd-6e0edae29cdf)

간단한 기능의 특성들이 3개 존재하고, json을 통한 직렬화를 이용한 데이터 저장이 구현되어있습니다.

5.옵션 버튼 : 게임의 음량을 설정할 수 있습니다.

### 메인 게임 화면

![image](https://github.com/user-attachments/assets/ec654753-216b-4f5e-949a-d1db9e094845)

메인 게임화면은 다음과같이 구성되어있으며, 게임을 시작하기 전 아래와 같이 UI에 대해 간단히 설명하는 UI가 출력됩니다.

![image](https://github.com/user-attachments/assets/fd324144-348d-46f2-8a2f-ce70c778a859)

### 튜토리얼

![image](https://github.com/user-attachments/assets/96feedb6-f61f-4589-83af-2ed12e72aa67)

만약 게임을 처음 플레이한다면 튜토리얼이 실행되며, 이를 통해 간단한 조작법을 학습할 수 있습니다.

튜토리얼은 상태패턴을 이용하여 제작되었으며, 튜토리얼을 플레이했는지 여부도 json을 통해 저장됩니다. 

---

## 게임 진행

![image](https://github.com/user-attachments/assets/8430080b-4947-44b5-9bf4-13c1e8779805)

게임을 처음 시작하면 약간의 자금과 대기시간이 주어지며,
적군의 스폰 위치, 아군의 베이스 위치, 그리고 상호작용이 불가능한 5개의 벽의 세가지 요소가 맵상에 무작위로 배치됩니다.

플레이어는 배치된 오브젝트들을 고려하여 최적의 위치에 방어시설들을 배치하여야 합니다.

![image](https://github.com/user-attachments/assets/ea2f81b6-7ac7-4238-a5c5-9ae9cad82c60)

게임은 50라운드동안 진행되며, 적들을 처치하여 획득한 재화들로 미로를 확장하고, 포탑을 늘리고, 강화하여 점점 강해지는 적들을 막아내야합니다.

![image](https://github.com/user-attachments/assets/0c28022d-c7fe-46c2-8034-37ea3a10a9a6)

총 50라운드가 지나면 게임을 클리어 할 수 있으며, 게임을 빨리 클리어할수록 더 높은 점수를 받을 수 있습니다.
또한, 영구적으로 적용되는 특성을 해제할 수 있는 포인트를 얻을 수 있으며 게임 시작화면에서 관리할 수 있습니다.

---
