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

### 게임 화면

![image](https://github.com/user-attachments/assets/ec654753-216b-4f5e-949a-d1db9e094845)

메인 게임화면은 다음과같이 구성되어있으며, 게임을 시작하기 전 아래와 같이 UI에 대해 간단히 설명하는 UI가 출력됩니다.

![image](https://github.com/user-attachments/assets/fd324144-348d-46f2-8a2f-ce70c778a859)


---

## 게임 진행

![image](https://github.com/user-attachments/assets/c03766e2-1fbc-42b6-8368-1d17f5faf325)

게임을 처음 시작하면 약간의 자금과 대기시간이 주어지며, 이 첫 대기시간동안 주어진 초기 자금으로 적들이 이동할 경로를 만들고 간단한 방어준비를 합니다.

처음 라운드에서는 대기시간이 넉넉하게 주어지기 때문에 시간이 많이 남을수도 있는데

만약 준비가 되었다면 현재 라운드 UI를 클릭하여 대기시간을 스킵할 수 있으며, 추후에 주어질 대기시간에도 동일하게 적용됩니다.

![image](https://github.com/user-attachments/assets/26d4c741-7a4c-481a-81de-6714a7b9eecb)

라운드를 진행하고 적들을 처치하며 획득한 재화들로 미로를 확장하고, 포탑을 늘리고, 강화하여 점점 강해지는 적들을 막아내야합니다.

총 50라운드가 지나면 게임을 클리어 할 수 있으며 빠르게 클리어할수록 높은 결과점수를 받을 수 있습니다.

---

## 추후 개발할 사항

### UI부분

옵션창과 게임 설명창, 그리고 일지정지 패널등의 내용을 추가하여 인게임에서 여러가지 정보를 얻거나 게임 설정을 할 수 있도록 만들 예정입니다.

### 게임 플레이 부분

반복적인 회차플레이를 즐길 수 있도록 여러가지 난이도들과 로그라이트적인 회차 특전(특성포인트 같은 것)을 만들 예정입니다.

보다 게임을 전략적으로 즐길 수 있도록 적들의 공세유형을 추가하고 미리 예고할 수 있게 만들 예정입니다.

게임을 도중에 중지하고 재개할 수 있도록 게임을 저장할 수 있는 기능을 만들 예정입니다.

보다 게임을 깊게 즐길 수 있도록 이전에 진행한 회차들의 기록들을 랭킹의 형태로 저장할 수 있게 만들 예정입니다.
