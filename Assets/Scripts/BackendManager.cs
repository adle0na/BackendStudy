using UnityEngine;
using BackEnd;
using System.Threading.Tasks;
public class BackendManager : MonoBehaviour
{
    void Start()
    {
        // 뒤끝 초기화
        var bro = Backend.Initialize(true);
        
        // 초기화에 대한 응답값
        if (bro.IsSuccess())
        {
            // 성공할 경우 StatusCode 204 Success
            Debug.Log("초기화 성공:" + bro);
        }
        else
        {
            // 실패할 경우 StatusCode 400대 에러 발생
            Debug.LogError("초기화 실패:" + bro);
        }

        Test();
    }
    
    async void Test()
    {
        await Task.Run(()=>
        {
            #region 함수 호출 메뉴얼

            #region 1. 회원가입 CustomSignUp
            //BackendLogin.Instance.CustomSignUp("user3", "1234");
            #endregion

            #region 2. 로그인 CustomLogin
            //BackendLogin.Instance.CustomLogin("user3","1234");
            #endregion
             
            // 로그인 이후 사용
            #region 3. 닉네임 변경 UpdateNickname
            //BackendLogin.Instance.UpdateNickname("괴수의 심장");
            #endregion

            #region 4. 데이터 삽입 GameDataInsert
            // BackendGameData.Instance.GameDataInsert();
            #endregion

            #region 5. 데이터 불러오기 GameDataGet
            //BackendGameData.Instance.GameDataGet();
            #endregion

            #region 6. 게임정보 수정 GameDataUpdate
            /*
            BackendGameData.Instance.GameDataGet(); // 데이터 삽입 함수
            
            // [추가] 서버에 불러온 데이터가 존재하지 않을 경우, 데이터를 새로 생성하여 삽입
            if (BackendGameData.userData == null) {
                BackendGameData.Instance.GameDataInsert();
            }

            BackendGameData.Instance.LevelUp(); // [추가] 로컬에 저장된 데이터를 변경

            BackendGameData.Instance.GameDataUpdate(); //[추가] 서버에 저장된 데이터를 덮어쓰기(변경된 부분만)
            */
            #endregion

            #region 7. 랭킹 등록 RankInsert
            // BackendRank.Instance.RankInsert("점수");
            #endregion

            #region 8. 랭킹 불러오기 RankGet
            //BackendRank.Instance.RankGet();
            #endregion

            #region 9. 차트 불러오기 ChartGet
            //BackendChart.Instance.ChartGet("67052");
            #endregion

            #region 10. 우편 불러오기 PostListGet
            //BackendPost.Instance.PostListGet(PostType.Admin);
            #endregion
            
            #region 11. 최신우편 하나 수령하여 저장하기 PostReceive
            //BackendPost.Instance.PostReceive(PostType.Admin, 0);
            #endregion

            #region 12. 우편 전부 수령하여 저장하기
            //BackendPost.Instance.PostReceiveAll(PostType.Admin);
            #endregion

            #region 13. 쿠폰 사용하여 아이템 저장하기
            //BackendCoupon.Instance.CouponUse("b2eb1f91e53fc822db");
            #endregion

            #region 14. 게임 로그 저장하기
            //BackendGameLog.Instance.GameLogInsert();
            #endregion

            #region 15. 친구 요청 보내기
            
            // user1에게 보낼것이므로 user계정 생성
            //BackendLogin.Instance.CustomSignUp("user2", "1234");
            //BackendLogin.Instance.UpdateNickname("강아지모히또");
            
            // 다시 로그인 하려면
            //BackendLogin.Instance.CustomLogin("user2","1234");
            // 친구 요청 보내는 함수
            //string user1Nickname = "고양이모히또";
            //BackendFriend.Instance.SendFriendRequest(user1Nickname);

            #endregion

            #region 16. 친구 요청 수락하기
            
            // 수락해야 하므로 다시 user1로 로그인
            //BackendLogin.Instance.CustomLogin("user1","1234");
            
            // 친구 리스트 불러오기
            //BackendFriend.Instance.GetReceivedRequestFriend();
            // 가장 최근 리스트 친구 수락
            //BackendFriend.Instance.ApplyFriend(0);
            
            #endregion

            #region 17. 친구 리스트 불러오기
            
            //BackendLogin.Instance.CustomLogin("user1", "1234");
            
            //BackendFriend.Instance.GetFriendList();

            #endregion

            #region 18. 길드 생성
            //BackendGuild.Instance.CreateGuild("죠죠의 기묘한 모험단");
            #endregion

            #region 19. 길드 찾아 가입 요청하기
            //BackendGuild.Instance.RequestGuildJoin("죠죠의 기묘한 모험단");
            #endregion
            
            #region 20. 길드 가입 요청 수락하기
            // 가장 최근에 신청한 유저 수락
            //BackendGuild.Instance.AcceptGuildJoinRequest(0);
            #endregion
            
            #region 21. 길드 기부
            //BackendGuild.Instance.ContributeGoods(); // 길드 굿즈 기부(추가) 함수
            #endregion
            
            #endregion
            Debug.Log("테스트를 종료합니다");
        });
    }
    
}
