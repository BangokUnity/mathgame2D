using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changePro : MonoBehaviour
{
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BlockG.shuf == 0)
        {
            text.text = string.Format("문제: {0}                                      점수: {1}\n(1) {2} \n(2) {3} \n(3) {4} \n(4) {5}", BlockG.pro, yes.score, BlockG.ans1, BlockG.ans2, BlockG.ans3, BlockG.ans4);
        }

        else if(BlockG.shuf == 1)
        {
            text.text = string.Format("문제: {0}                                      점수: {1}\n(1) {2} \n(2) {3} \n(3) {4} \n(4) {5}", BlockG.pro, yes.score, BlockG.ans2, BlockG.ans1, BlockG.ans4, BlockG.ans3);
        }

        else if (BlockG.shuf == 2)
        {
            text.text = string.Format("문제: {0}                                      점수: {1}\n(1) {2} \n(2) {3} \n(3) {4} \n(4) {5}", BlockG.pro, yes.score, BlockG.ans4, BlockG.ans2, BlockG.ans1, BlockG.ans3);
        }

        else if (BlockG.shuf == 3)
        {
            text.text = string.Format("문제: {0}                                      점수: {1}\n(1) {2} \n(2) {3} \n(3) {4} \n(4) {5}", BlockG.pro, yes.score, BlockG.ans3, BlockG.ans4, BlockG.ans2, BlockG.ans1);
        }
    }
}
