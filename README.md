1. During annotation, --> increases the value, <-- decreases the value, space returns the cursor back to 0.

2. A trackBar value of 1000 means the video is paused here. Use the next trackBar value after 1000 to reduce errors. 

3. The input VideoList.txt is of the format:
   USERID,Segment1,Segment2,Segment3,TaskModeofClip1,TaskModeofClip2,TaskModeofClip3  (MAKE SURE THERE IS NO SPACE BEHIND THE COMMA)

   USERID: can be any string
   Segment1,2,3: only the NAME of the segment, not path (path will be set by choosing at the beginning of the program)
   TaskMode: to set the labels of trackBar, can be A or B.