﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Blind
{
    public class ConversationScriptStorage : MonoBehaviour
    {
        static ConversationScriptStorage _instance = null;
        public static ConversationScriptStorage Instance
        {
            get
            {
                Init();
                return _instance;
            }
        }
        static void Init()
        {
            if (_instance == null)
            {
                GameObject go = new GameObject() { name = "@ConversationStorage" };
                go.AddComponent<ConversationScriptStorage>();

                DontDestroyOnLoad(go);
                _instance = go.GetComponent<ConversationScriptStorage>();
                _instance.Init_Dict();
            }
        }
        private void Start()
        {
            Init();
        }
        Dictionary<string, List<string>> _dict = new Dictionary<string, List<string>>();
        public List<string> GetConversation(string text)
        {
            List<string> list = null;
            _dict.TryGetValue(text, out list);

            return list;
        }
        void Init_Dict()
        {
            _dict.Add("Test1", new List<string>()
            {
                "안녕하세요",
                "반갑습니다 반갑습니다 반갑습니다 반갑습니다 반갑습니다 반갑습니다 반갑습니다",
                "수고하세요수고하세요수고하세요수고하세요수고하세요수고하세요수고하세요수고하세요수고하세요수고하세요수고하세요수고하세요수고하세요수고하세요수고하세요수고하세요수고하세요"
            });
            _dict.Add("Test2", new List<string>()
            {
                "안녕?안녕?안녕?안녕?안녕?안녕?안녕?안녕?안녕?안녕?안녕?안녕?안녕?안녕?안녕?안녕?안녕?안녕?",
                "잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!잘가!!"
            });
        }
    }
}

