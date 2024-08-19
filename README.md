# RTD_Public

---

## 개요

### 프로젝트 소개

C9조 Nine to Nine의 ProjectRTD입니다.

저희가 만든 게임은 전략성이 가미된 타워디펜스 게임입니다.

넓은 개활지에서 적들이 지나다닐 경로를 직접 만들고 포탑을 지어서 적을 막는 방식으로 진행합니다.

---

## 게임 화면

우선 게임 화면에 대한 설명입니다.

### 시작 화면

![image](https://github.com/user-attachments/assets/600daeff-be20-484e-a83b-62d54e4d1145)

게임의 시작화면은 다음과 같이 구성되어있습니다.

1.게임 타이틀 : 현재 임시로 적어둔 게임 타이틀입니다. 추후에 게임의 이름이 정해지면 이름이 들어갈 공간입니다.

2.게임 시작버튼 : 게임을 시작할 수 있는 버튼입니다.

3.게임 설명버튼(내용물 미구현) : 기능은 하나, 게임 설명창의 내용물은 없습니다.

4.옵션 버튼(내용물 미구현) : 마찬가지로 기능은 하나, 옵션창의 내용물은 없습니다.

### 게임 화면

![imageee](https://github.com/user-attachments/assets/7f5a86d4-d0ec-4779-b49c-5732d681e0d0)

메인 게임화면은 다음과같이 구성되어있습니다.

1. 플레이어의 베이스 : 적이 도달하면 목숨이 깎이며, 목숨이 0이 되면 패배합니다. 추후에 남은 목숨을 표시할 수 있게 UI로서도 기능할 예정입니다.

2. 적의 생성 지점 : 적이 생성되는 지점입니다. 이곳에서 적이 생성되고, 자동으로 플레이어의 베이스까지 경로를 찾아 이동합니다.

3. 현재 라운드 : 현재의 라운드가 표시되는 UI입니다. 적이 나오지 않는 라운드 대기상태일때는 라운드 대기상태를 스킵하는 버튼의 기능을 겸합니다.

4. 현재 타이머 : 현재의 타이머가 표시되는 UI입니다. 적을 다 처치하지 못해도 타이머가 다 지나면 자동으로 다음 라운드로 진행되며, 적을 모두 처치했을때 남은 시간만큼 점수에 가산됩니다.

5. 일시정지 버튼 : 게임을 일시정지합니다. 한번 더 누르면 일시정지를 해제합니다.

6. 적의 공세 유형(미구현) : 다음 라운드에 어떤 적들이 공격해올지 미리 알 수 있게 표시해주는 UI를 제작할 예정입니다. 적들의 공세 유형에 따라 유연하게 전략을 선택할 수 있게 만드는 것이 목표입니다.

7. 빌드 버튼 그룹 : 여러가지 오브젝트(토대와 타워)들을 선택해서 건설할 수 있게 해주는 버튼 그룹입니다. 판매도 선택할 수 있습니다.

8. 업그레이드 버튼 : 업그레이드 패널을 활성화하는 버튼입니다. 업그레이드 패널에서 타워들을 업그레이드합니다.

9. 현재 자금 : 현재 가진 자금을 표시해주는 UI입니다.

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
