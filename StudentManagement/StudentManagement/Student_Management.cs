﻿/*
 *  프로그램명 : 성적관리 프로그램
 *  작성자 : 4TEAM   
 *  작성일 : 2019-10-02
 *  프로그램 설명 : 학생의 성적을 관리하는 프로그램
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //파일입출력 네임스페이스

namespace StudentManagement
{
    public class Student
    {
        // 학생 정보 : 이름 학번 국어 영어 수학 C# 총점 평균 등수
        private string Name;
        private int StudentID;
        private double Korean;
        private double English;
        private double Math;
        private double Cs;
        private double Grade;
        private double Totalscore;
        private double Average;
        private int Rank;


        public class Menu { } //메뉴창
        public class Input { } //입력받기
        public class Output { } //출력하기
        public class Grade
        {
            public void GetGrade(Student st)
            {
                st.Grade = (GetSubGrade(st.English) + GetSubGrade(st.Korean) + GetSubGrade(st.Math) + GetSubGrade(st.Cs)) / 4;
            }
            public double GetSubGrade(double Score)
            {
                if (Score >= 95)
                {
                    return 4.5;
                }
                else if (Score < 95 && Score >= 90)
                {
                    return 4.0;
                }
                else if (Score < 90 && Score >= 85)
                {
                    return 3.5;
                }
                else if (Score < 85 && Score >= 80)
                {
                    return 3.0;
                }
                else if (Score < 80 && Score >= 75)
                {
                    return 2.5;
                }
                else if (Score < 75 && Score >= 70)
                {
                    return 2.0;
                }
                else if (Score < 70 && Score >= 60)
                {
                    return 1.0;
                }
                else
                {
                    return 0.0;
                }
            }
            public void GetAverage(Student st)
            {
                st.Average = (st.Korean + st.Math + st.English + st.Cs) / 4;
            }
            public void GetTotalScore(Student st)
            {
                st.Totalscore = st.Korean + st.Math + st.English + st.Cs;
            }
        } //성적계산하기
        public class Add { } //Info추가
        public class Insert { } //Info삽입
        public class Delete { } //Info삭제
        public class Scholarship { } //장학생

        public class Student_Management
        {
            static void Main(string[] args)
            {

            }
        }
    }
}
