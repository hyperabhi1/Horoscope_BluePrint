--create table F2BASE_ME (p0 CHAR(2),p1 CHAR(2),p2 CHAR(2),p3 CHAR(2),p4 CHAR(2),p5 CHAR(2),p6 CHAR(2),p7 CHAR(2),p8 CHAR(2));
--create table F2BASE_SU (p0 CHAR(2),p1 CHAR(2),p2 CHAR(2),p3 CHAR(2),p4 CHAR(2),p5 CHAR(2),p6 CHAR(2),p7 CHAR(2),p8 CHAR(2));
--create table F2BASE_MO (p0 CHAR(2),p1 CHAR(2),p2 CHAR(2),p3 CHAR(2),p4 CHAR(2),p5 CHAR(2),p6 CHAR(2),p7 CHAR(2),p8 CHAR(2));
--create table F2BASE_VE (p0 CHAR(2),p1 CHAR(2),p2 CHAR(2),p3 CHAR(2),p4 CHAR(2),p5 CHAR(2),p6 CHAR(2),p7 CHAR(2),p8 CHAR(2));
--create table F2BASE_MA (p0 CHAR(2),p1 CHAR(2),p2 CHAR(2),p3 CHAR(2),p4 CHAR(2),p5 CHAR(2),p6 CHAR(2),p7 CHAR(2),p8 CHAR(2));
--create table F2BASE_JU (p0 CHAR(2),p1 CHAR(2),p2 CHAR(2),p3 CHAR(2),p4 CHAR(2),p5 CHAR(2),p6 CHAR(2),p7 CHAR(2),p8 CHAR(2));
--create table F2BASE_SA (p0 CHAR(2),p1 CHAR(2),p2 CHAR(2),p3 CHAR(2),p4 CHAR(2),p5 CHAR(2),p6 CHAR(2),p7 CHAR(2),p8 CHAR(2));

--create table F2BASE_EXPLODE_ME (pkey char(18),combo char(18), x1 char(2),x2 char(2),x3 char(2),x4 char(2),x5 char(2), x6 char(2),x7 char(2),x8 char(2),x9 char(2),p char(1));
--create table F2BASE_EXPLODE_MO (pkey char(18),combo char(18), x1 char(2),x2 char(2),x3 char(2),x4 char(2),x5 char(2), x6 char(2),x7 char(2),x8 char(2),x9 char(2),p char(1));
--create table F2BASE_EXPLODE_VE (pkey char(18),combo char(18), x1 char(2),x2 char(2),x3 char(2),x4 char(2),x5 char(2), x6 char(2),x7 char(2),x8 char(2),x9 char(2),p char(1));
--create table F2BASE_EXPLODE_MA (pkey char(18),combo char(18), x1 char(2),x2 char(2),x3 char(2),x4 char(2),x5 char(2), x6 char(2),x7 char(2),x8 char(2),x9 char(2),p char(1));
--create table F2BASE_EXPLODE_SU (pkey char(18),combo char(18), x1 char(2),x2 char(2),x3 char(2),x4 char(2),x5 char(2), x6 char(2),x7 char(2),x8 char(2),x9 char(2),p char(1));
--create table F2BASE_EXPLODE_SA (pkey char(18),combo char(18), x1 char(2),x2 char(2),x3 char(2),x4 char(2),x5 char(2), x6 char(2),x7 char(2),x8 char(2),x9 char(2),p char(1));
--create table F2BASE_EXPLODE_JU (pkey char(18),combo char(18), x1 char(2),x2 char(2),x3 char(2),x4 char(2),x5 char(2), x6 char(2),x7 char(2),x8 char(2),x9 char(2),p char(1));

--create table F2BASE_EXPLODE_ASC_ME (pkey char(18),combo char(18), x1 char(2),x2 char(2),x3 char(2),x4 char(2),x5 char(2), x6 char(2),x7 char(2),x8 char(2),p char(1));
--create table F2BASE_EXPLODE_ASC_MO (pkey char(18),combo char(18), x1 char(2),x2 char(2),x3 char(2),x4 char(2),x5 char(2), x6 char(2),x7 char(2),x8 char(2),p char(1));
--create table F2BASE_EXPLODE_ASC_VE (pkey char(18),combo char(18), x1 char(2),x2 char(2),x3 char(2),x4 char(2),x5 char(2), x6 char(2),x7 char(2),x8 char(2),p char(1));
--create table F2BASE_EXPLODE_ASC_MA (pkey char(18),combo char(18), x1 char(2),x2 char(2),x3 char(2),x4 char(2),x5 char(2), x6 char(2),x7 char(2),x8 char(2),p char(1));
--create table F2BASE_EXPLODE_ASC_SU (pkey char(18),combo char(18), x1 char(2),x2 char(2),x3 char(2),x4 char(2),x5 char(2), x6 char(2),x7 char(2),x8 char(2),p char(1));
--create table F2BASE_EXPLODE_ASC_SA (pkey char(18),combo char(18), x1 char(2),x2 char(2),x3 char(2),x4 char(2),x5 char(2), x6 char(2),x7 char(2),x8 char(2),p char(1));
--create table F2BASE_EXPLODE_ASC_JU (pkey char(18),combo char(18), x1 char(2),x2 char(2),x3 char(2),x4 char(2),x5 char(2), x6 char(2),x7 char(2),x8 char(2),p char(1));

--create table MATCH_FILE_ME (uid char(10),hid char(10),planet char(2),pkey char(18),combo char(18),CUSPID char(18),CUSPSTR char(18),MATCHSTR char(18),n int,p char(1));
--create table MATCH_FILE_MO (uid char(10),hid char(10),planet char(2),pkey char(18),combo char(18),CUSPID char(18),CUSPSTR char(18),MATCHSTR char(18),n int,p char(1));
--create table MATCH_FILE_VE (uid char(10),hid char(10),planet char(2),pkey char(18),combo char(18),CUSPID char(18),CUSPSTR char(18),MATCHSTR char(18),n int,p char(1));
--create table MATCH_FILE_MA (uid char(10),hid char(10),planet char(2),pkey char(18),combo char(18),CUSPID char(18),CUSPSTR char(18),MATCHSTR char(18),n int,p char(1));
--create table MATCH_FILE_SU (uid char(10),hid char(10),planet char(2),pkey char(18),combo char(18),CUSPID char(18),CUSPSTR char(18),MATCHSTR char(18),n int,p char(1));
--create table MATCH_FILE_SA (uid char(10),hid char(10),planet char(2),pkey char(18),combo char(18),CUSPID char(18),CUSPSTR char(18),MATCHSTR char(18),n int,p char(1));
--create table MATCH_FILE_JU (uid char(10),hid char(10),planet char(2),pkey char(18),combo char(18),CUSPID char(18),CUSPSTR char(18),MATCHSTR char(18),n int,p char(1));

--create table MATCH_FILE_ASC_ME (uid char(10),hid char(10),planet char(2),pkey char(18),combo char(18),CUSPID char(18),CUSPSTR char(18),MATCHSTR char(18),n int,p char(1));
--create table MATCH_FILE_ASC_MO (uid char(10),hid char(10),planet char(2),pkey char(18),combo char(18),CUSPID char(18),CUSPSTR char(18),MATCHSTR char(18),n int,p char(1));
--create table MATCH_FILE_ASC_VE (uid char(10),hid char(10),planet char(2),pkey char(18),combo char(18),CUSPID char(18),CUSPSTR char(18),MATCHSTR char(18),n int,p char(1));
--create table MATCH_FILE_ASC_MA (uid char(10),hid char(10),planet char(2),pkey char(18),combo char(18),CUSPID char(18),CUSPSTR char(18),MATCHSTR char(18),n int,p char(1));
--create table MATCH_FILE_ASC_SU (uid char(10),hid char(10),planet char(2),pkey char(18),combo char(18),CUSPID char(18),CUSPSTR char(18),MATCHSTR char(18),n int,p char(1));
--create table MATCH_FILE_ASC_SA (uid char(10),hid char(10),planet char(2),pkey char(18),combo char(18),CUSPID char(18),CUSPSTR char(18),MATCHSTR char(18),n int,p char(1));
--create table MATCH_FILE_ASC_JU (uid char(10),hid char(10),planet char(2),pkey char(18),combo char(18),CUSPID char(18),CUSPSTR char(18),MATCHSTR char(18),n int,p char(1));
