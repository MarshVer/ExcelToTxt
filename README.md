# ExcelToTxt
读取Excel文件，并按一定规则将文字替换为Id或字母写入到txt文件中
* 注意Excel文件、LSTCAT.TXT和LSTSTYLE.TXT列的顺序和数量要保持一致

# Excel文件为源文件
1. 若Excel文件后缀为xls,请先打开并将文件另存为后缀为xlsx的Excel文件
2. Excel文件列依次为reclevel	gender	recordname	eventnum	eventname	rectime	swimmer	team	cdate	csite	remark

# DH文件夹为选中文件夹
1. DH文件中必有LSTCAT.TXT和LSTSTYLE.TXT
2. LSTCAT.TXT文件数据列为Category;AbrevCat;
3. LSTSTYLE.TXT文件数据列为idStyle;Style;StyleAbrev;

# 文件介绍
1. LSTCAT.TXT文件为性别文件，可能存在男子，女子，男女，男子甲级等
2. LSTSTYLE.TXT文件为泳姿文件，主要用于泳姿替换为泳姿id
3. LSTREC.TXT文件为转换后生成的文件（可由软件自动生成）
