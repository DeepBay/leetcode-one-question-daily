class Solution(object):
    def lengthOfLastWord(self, s):
        list=s.split(" ")
        list.reverse()
        for i in list:
            if len(i)>0:
                word=i
                break
        return len(word)
