using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class DummyInputClass
    {
        //차례 대로 성,이름,전화번호,메일을 조합하기 위한 문자열        
        static string[] FirstName = { "박","박", "박","박", "이","이", "김","김","김", "유", "장", "오", "김","김","김", "김",
                                   "노", "윤","강","최","우","정","하","옥", "권", "권", "권", "권", "임"};
        static string[] LastName = { "지", "훈", "용", "덕", "종", "은", "남", "준", "석", "영", "현", "창", "민","창", "민","창", "민","창", "민","창", "민",
            "창", "민","창", "민","창", "민","창", "민","창", "민","창", "민","창", "민","창", "민","창", "민","창", "민","창", "민","창", "민","창", "민",
            "근", "희","근", "희","근", "희","근", "희","근", "주", "희", "주","주","주","주","주","주","주","희","희","희","희","희","희","희",
            "지", "용","지", "용","지", "용","지", "용","지", "용","지", "용","지", "용","지", "용","지", "용","지", "용",
                                   "정", "준", "상", "택", "협", "서", "희","지","훈","진","우","성", "운", "운", "운", "운", "영", "영", "영", "영", "영", "영"};
        static string[] FirstPhoneNumber = { "010", "010", "010", "011", "019", "017", "016", "018" };
        static string[] MailSP = { "korea.com", "nate.com", "yahoo.co.kr", "hanmail.net", "daum.net", "naver.com" };

        static string[] FirstAddress = { "서울", "대전", "대구", "부산", "광주", "제주", "포항" };
        static string[] LastAddress = { "북구", "동구", "서구", "남구", "중구" };

        //count 만큼 이름을 랜덤으로 만들어서 문자열의 배열을 리턴한다.
        static public string[] GetName(int count)
        {
            Random r = new Random();
            string[] Name = new string[count];
            for (int i = 0; i < count; i++)
            {
                Name[i] = string.Format("{0}{1}{2}",
                    FirstName[r.Next(0, FirstName.Length)],
                    LastName[r.Next(0, LastName.Length)],
                    LastName[r.Next(0, LastName.Length)]);
                if (Name[i][1] == Name[i][2]) i--; // 중간 글자와 세번째 글자가 중복 되면 다시한번 루프를 한번더 돕니다.
            }
            return Name;
        }
        //count 만큼 전화번호를 만들어서 문자열의 배열을 리턴한다.
        static public string[] GetPhoneNumber(int count)
        {
            Random r = new Random();
            string[] PhoneNumber = new string[count];
            for (int i = 0; i < count; i++)
            {
                PhoneNumber[i] = string.Format("{0}-{1}-{2}",
                    FirstPhoneNumber[r.Next(0, FirstPhoneNumber.Length)],
                    r.Next(1111, 10000).ToString(),
                    r.Next(1111, 10000).ToString());
            }
            return PhoneNumber;
        }
        //count 만큼 메일 주소를 만들어서 문자열의 배열을 리턴한다.
        //문자열의 재조합이 빈번?해서 StringBuilder을 사용했습니다.
        static public string[] GetMailAddress(int count)
        {
            Random r = new Random();
            string[] MailAddress = new string[count];
            StringBuilder strb = new StringBuilder(12);
            for (int i = 0; i < count; i++)
            {
                int idcount = r.Next(5, 12);
                for (int j = 0; j < idcount; j++)
                    strb.Append((char)r.Next(97, 123));

                MailAddress[i] = string.Format("{0}@{1}",
                    strb, MailSP[r.Next(0, MailSP.Length)]);
                strb.Remove(0, strb.Length);
            }
            return MailAddress;
        }

        static public string[] GetAddress(int count)
        {
            Random r = new Random();
            string[] Address = new string[count];
            for (int i = 0; i < count; i++)
            {
                Address[i] = string.Format("{0} {1} 입니다.",
                    FirstAddress[r.Next(0, FirstAddress.Length)],
                    LastAddress[r.Next(0, LastAddress.Length)]);
                //if (Name[i][1] == Name[i][2]) i--; // 중간 글자와 세번째 글자가 중복 되면 다시한번 루프를 한번더 돕니다.
            }
            return Address;
        }
        static public int[] GetAge(int count)
        {
            Random r = new Random();

            int[] age = new int[count];
            for (int i = 0; i < count; i++)
            {
                age[i] = r.Next(20, 70);
            }

            return age;
        }
    }
}
