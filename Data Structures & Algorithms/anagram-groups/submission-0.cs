public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string,List<string>>();
        for(int i=0; i<strs.Length;i++){
            var charArr = strs[i].ToCharArray();
            Array.Sort(charArr);
            var str = new string(charArr);
            if(dict.ContainsKey(str)){
                dict[str].Add(strs[i]);
            }
            else{
                dict[str] = new List<string> {strs[i]};
            }
        }
        var res = new List<List<string>>();
        foreach(var entry in dict){
            res.Add(entry.Value);
        }
        return res;
    }
}
