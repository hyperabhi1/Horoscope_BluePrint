a1 =  {'Su','Mo','Ma','Ra','Ju','Sa','Me','Ke','Ve'}
a2 = 	{'Mo','Ma','Ra','Ju','Sa','Me','Ke','Ve','Su'}
a3 =  {'Ma','Ra','Ju','Sa','Me','Ke','Ve','Su','Mo'}
a4 =  {'Ra','Ju','Sa','Me','Ke','Ve','Su','Mo','Ma'}
a5 =  {'Ju','Sa','Me','Ke','Ve','Su','Mo','Ma','Ra'}
a6 =  {'Sa','Me','Ke','Ve','Su','Mo','Ma','Ra','Ju'}
a7 =  {'Me','Ke','Ve','Su','Mo','Ma','Ra','Ju','Sa'}
a8 =  {'Ke','Ve','Su','Mo','Ma','Ra','Ju','Sa','Me'}
a9 =  {'Ve','Su','Mo','Ma','Ra','Ju','Sa','Me','Ke'}


select 1
use c:\temp\f1ME
go top

select 2
use c:\temp\f2 excl
zap
index on p1+p2+p3+p4+p5+p6+p7 to c:\temp\index1
set index to c:\temp\index1

select 3
use c:\temp\p1
set index to c:\temp\p1INDEX

counter = 0

sele 1
go top

do while .not. eof()
	store upper(p1) to mp1
	store upper(p2) to mp2
	store upper(p3) to mp3
	store upper(p4) to mp4
	store upper(p5) to mp5
	store upper(p6) to mp6
	store upper(p7) to mp7
	store mp7 to mp8
	
	? MP1
	? MP2
	? MP3
	? MP4
	? MP5
	? MP6
	? MP7
	? "p8"
	? MP8
	
	counter = counter + 1
	if counter = 50
		? counter
		counter = 1
	endif

	
	for i = 1 to 9
			mp_5 = getp(i,mp5)
				for j = 1 to 9
						mp_6 = getp(j,mp6)
						for k = 1 to 9
							mp_7 = getp(k,mp7)
									for l = 1 to 9
										mp_8 = getp(l,mp8)
										select 2
										appe blank
											replace p1 with mp1
											replace p2 with mp2
											replace p3 with mp3
											replace p4 with mp4
											replace p5 with mp_5
											replace p6 with mp_6
											replace p7 with mp_7
											replace p8 with mp_8
								endfor
						endfor
				endfor
	endfor
	sele 1
	skip
enddo
close all

function getp
param ind, planet
planet = upper(planet)
rp = ''
if planet = 'SU'
	rp = a1[ind]
endif
if planet = 'MO'
	rp =  a2[ind]
endif
if planet = 'MA'
	rp =  a3[ind]
endif
if planet = 'RA'
	rp =  a4[ind]
endif
if planet = 'JU'
	rp =  a5[ind]
endif
if planet = 'SA'
	rp =  a6[ind]
endif
if planet = 'ME'
	rp =  a7[ind]
endif
if planet = 'KE'
	rp =  a8[ind]
endif
if planet = 'VE'
	rp = a9[ind]
endif
return upper(rp)

