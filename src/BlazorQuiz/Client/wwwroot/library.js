
function add() {
    // SDK를 초기화 합니다. 사용할 앱의 JavaScript 키를 설정해 주세요.
    Kakao.init('2b5793241772e27fc080c267e013566e');

    // SDK 초기화 여부를 판단합니다.
    console.log(Kakao.isInitialized());
    Kakao.Link.sendDefault({
        objectType: 'text',
        text:
            '롤렉스 덕후 테스트!!! 당신은 진정한 덕후? ? ?',
        link: {
            mobileWebUrl: 'https://blazorquizserver20220204164221.azurewebsites.net/Quiz',
            webUrl: 'https://blazorquizserver20220204164221.azurewebsites.net/Quiz',
        },
    })
}

//<script type="text/javascript">
//    function sendLink() {
//        Kakao.Link.sendDefault({
//            objectType: 'text',
//            text:
//                '기본 템플릿으로 제공되는 텍스트 템플릿은 텍스트를 최대 200자까지 표시할 수 있습니다. 텍스트 템플릿은 텍스트 영역과 하나의 기본 버튼을 가집니다. 임의의 버튼을 설정할 수도 있습니다. 여러 장의 이미지, 프로필 정보 등 보다 확장된 형태의 카카오링크는 다른 템플릿을 이용해 보낼 수 있습니다.',
//            link: {
//                mobileWebUrl: 'https://developers.kakao.com',
//                webUrl: 'https://developers.kakao.com',
//            },
//        })
//    }
//</script>
