public c01,c02,c03,c04,c05,c06,c07,c08,c09,c10,c11,c12
	
	public m_planet
	m_planet = 'ME'
	
	select 1
	use c:\temp\f2su
	
	select 2
	use c:\temp\cusp
	
	select 3
	use c:\temp\match_file excl
	zap

	select 4
	use c:\temp\unmatch_file excl
	zap

	select 2
	
	go top
	do while .not. eof()
	
		store len(ltrim(rtrim(s1))) to tl
		store tl/2 to l
		
		if cuspid = '01'
			c01  = new array(l)
			start = 1
			for k = 1 to l
				c01[k] = substr(s1,start,2)
				start = start + 2
			endfor	
		endif

		if cuspid = '02'
			c02  = new array(l)
			start = 1
			for k = 1 to l
				c02[k] = substr(s1,start,2)
				start = start + 2
			endfor	
		endif

		if cuspid = '03'
			c03  = new array(l)
			start = 1
			for k = 1 to l
				c03[k] = substr(s1,start,2)
				start = start + 2
			endfor	
		endif

		if cuspid = '04'
			c04  = new array(l)
			start = 1
			for k = 1 to l
				c04[k] = substr(s1,start,2)
				start = start + 2
			endfor	
		endif

		if cuspid = '05'
			c05  = new array(l)
			start = 1
			for k = 1 to l
				c05[k] = substr(s1,start,2)
				start = start + 2
			endfor	
		endif

		if cuspid = '06'
			c06  = new array(l)
			start = 1
			for k = 1 to l
				c06[k] = substr(s1,start,2)
				start = start + 2
			endfor	
		endif

		if cuspid = '07'
			c07  = new array(l)
			start = 1
			for k = 1 to l
				c07[k] = substr(s1,start,2)
				start = start + 2
			endfor	
		endif

		if cuspid = '08'
			c08  = new array(l)
			start = 1
			for k = 1 to l
				c08[k] = substr(s1,start,2)
				start = start + 2
			endfor	
		endif

		if cuspid = '09'
			c09  = new array(l)
			start = 1
			for k = 1 to l
				c09[k] = substr(s1,start,2)
				start = start + 2
			endfor	
		endif

		if cuspid = '10'
			c10  = new array(l)
			start = 1
			for k = 1 to l
				c10[k] = substr(s1,start,2)
				start = start + 2
			endfor	
		endif

		if cuspid = '11'
			c11  = new array(l)
			start = 1
			for k = 1 to l
				c11[k] = substr(s1,start,2)
				start = start + 2
			endfor	
		endif

		if cuspid = '12'
			c12  = new array(l)
			start = 1
			for k = 1 to l
				c12[k] = substr(s1,start,2)
				start = start + 2
			endfor	
		endif
	skip
	enddo
	
	a8 = new array(8)

	sele 1
	go top
	counter = 0
	tcounter = 0
	
	do while .not. eof()
		
		a8[1] = 'ME'
		a8[2] = p1
		a8[3] = p2
		a8[4] = p3
		a8[5] = p4
		a8[6] = p5
		a8[7] = p6
		a8[8] = p7
		
		key = a8[1] + a8[2] + a8[3] + a8[4] + a8[5] + a8[6] + a8[7] + a8[8]
		
		match_key(a8,key,c01,"01")
		match_key(a8,key,c02,"02")
		match_key(a8,key,c03,"03")
		match_key(a8,key,c04,"04")
		match_key(a8,key,c05,"05")
		match_key(a8,key,c06,"06")
		match_key(a8,key,c07,"07")
		match_key(a8,key,c08,"08")
		match_key(a8,key,c09,"09")
		match_key(a8,key,c10,"10")
		match_key(a8,key,c10,"11")
		match_key(a8,key,c11,"12")
		select 1
		skip
		counter = counter + 1
		if counter = 500
			tcounter = tcounter + counter
			counter = 0
			? tcounter
			wait
		endif	
	enddo
	close all

	*** Core function

	function match_key(combo,xkey,cuspp,cloc)
	
	fl1 = "N"
	fl2 = "N"
	fl3 = "N"
	fl4 = "N"
	fl5 = "N"
	fl6 = "N"
	fl7 = "N"
	fl8 = "N"
	
	m_str= ""
	
	cusp_len = alen(cuspp)
	combo_len = alen(combo)
	
	xcusp = new array(cusp_len)
	xcombo = new arrAy(combo_len)
	
	pstr1 = ""
	for i = 1 to combo_len
		pstr1 = pstr1 + Combo[i] 
	endfor
	
	pstr2 = ""
	for i = 1 to cusp_len
			pstr2 = pstr2 + Cuspp[i]
	endfor

	** Check first position with 4 
	
	acopy(cuspp,xcusp)
	acopy(combo,xcombo)

	pointer = 0

	? cloc
	? pstr1
	? pstr2
	
	for i = 1 to cusp_len
		if xcombo[1] = cuspp[i]
		 pointer = 1
		endif 
	endfor
	
	if pointer = 1
	for i = 1 to cusp_len
		if xcombo[2] = cuspp[i]
		 pointer = 2
		endif 
	endfor
	endif
	
	if pointer = 2
	for i = 1 to cusp_len
		if xcombo[3] = cuspp[i]
		 pointer = 3
		endif 
	endfor
	endif
	
	if pointer = 3
	for i = 1 to cusp_len
		if xcombo[4] = cuspp[i]
		 pointer = 4
		endif 
	endfor
	endif
	
	if pointer < 2
		? 'Pointer < 2 return'
					select 4
					appe blank
					replace uid with "XXXXXXXXXXXXX"
					replace hid with "100001"
					replace planet with m_planet
					replace key with xkey
					replace combo with pstr1
					replace cuspstr with pstr2
					replace cuspid with cloc
					replace matchstr with m_str
					select 1
		return
	endif

	if pointer = 4
		xcombo[1] = combo[1]
		xcombo[2] = combo[2]
		xcombo[3] = combo[3]
		xcombo[4] = combo[4]
		xcombo[5] = combo[8]
		xcombo[6] = combo[7]
		xcombo[7] = combo[6]
		xcombo[8] = combo[5]
	endif
	
	if pointer = 3
		xcombo[1] = combo[1]
		xcombo[2] = combo[2]
		xcombo[3] = combo[3]
		xcombo[4] = combo[8]
		xcombo[5] = combo[7]
		xcombo[6] = combo[6]
		xcombo[7] = combo[5]
		xcombo[8] = combo[4]
	endif

	if pointer = 2
		xcombo[1] = combo[1]
		xcombo[2] = combo[2]
		xcombo[3] = combo[8]
		xcombo[4] = combo[7]
		xcombo[5] = combo[6]
		xcombo[6] = combo[5]
		xcombo[7] = combo[4]
		xcombo[8] = combo[3]
	endif
	
	for i = 1 to cusp_len
			if xcombo[1] = xcusp[i]
					xcusp[i] = 'XX'
					fl1 = 'Y'
					m_str = m_str + xcombo[1]
					exit
			else		
				if xcombo[1] = cuspp[i]
						m_str = m_str + xcombo[1]
						fl1 = 'Y'
				endif
			endif	
	endfor
	if fl1 = 'Y'
	for i = 1 to cusp_len
			if xcombo[2] = xcusp[i]
					m_str = m_str + xcombo[2]
					xcusp[i] = 'XX'
					fl2 = 'Y'
					exit
			else		
				if xcombo[2] = cuspp[i]
						m_str = m_str + xcombo[2]
						fl2 = 'Y'
				endif
			endif
	endfor
	endif

	if fl1 = 'Y' and fl2 = 'Y'
	for i = 1 to cusp_len
			if xcombo[3] = xcusp[i]
					m_str = m_str + xcombo[3]
					xcusp[i] = 'XX'
					fl3 = 'Y'
					exit
			else		
				if xcombo[3] = cuspp[i]
						m_str = m_str + xcombo[3]
						fl3 = 'Y'
				endif
			endif	
	endfor
	endif

	if fl1 = 'Y' and fl2 = 'Y' and fl3 = 'Y'
	for i = 1 to cusp_len
			if xcombo[4] = xcusp[i]
					m_str = m_str + xcombo[4]
					xcusp[i] = 'XX'
					fl4 = 'Y'
					exit
			else		
				if xcombo[4] = cuspp[i]
						m_str = m_str + xcombo[4]
						fl4 = 'Y'
				endif
			endif	
	endfor
	endif

	if fl1 = 'Y' and fl2 = 'Y' and fl3 = 'Y' and fl4 = 'Y'
	for i = 1 to cusp_len
			if xcombo[5] = xcusp[i]
					m_str = m_str + xcombo[5]
					xcusp[i] = 'XX'
					fl5 = 'Y'
					exit
			else		
				if xcombo[5] = cuspp[i]
						m_str = m_str + xcombo[5]
						fl5 = 'Y'
				endif
			endif	
	endfor
	endif

	if fl1 = 'Y' and fl2 = 'Y' and fl3 = 'Y' and fl4 = 'Y' and fl5 = 'Y'
	for i = 1 to cusp_len
			if xcombo[6] = xcusp[i]
					m_str = m_str + xcombo[6]
					xcusp[i] = 'XX'
					fl6 = 'Y'
					exit
			else		
				if xcombo[6] = cuspp[i]
						m_str = m_str + xcombo[6]
						fl6 = 'Y'
				endif
			endif	
	endfor
	endif

	if fl1 = 'Y' and fl2 = 'Y' and fl3 = 'Y' and fl4 = 'Y' and fl5 = 'Y' and fl6 = 'Y'
	for i = 1 to cusp_len
			if xcombo[7] = xcusp[i]
					m_str = m_str + xcombo[7]
					xcusp[i] = 'XX'
					fl7 = 'Y'
					exit
			else		
				if xcombo[7] = cuspp[i]
						m_str = m_str + xcombo[7]
						fl7 = 'Y'
				endif
			endif	
	endfor
	endif

	if fl1 = 'Y' and fl2 = 'Y' and fl3 = 'Y' and fl4 = 'Y' and fl5 = 'Y' and fl6 = 'Y' and fl7 = 'Y'
	for i = 1 to cusp_len
			if xcombo[8] = xcusp[i]
					m_str = m_str + xcombo[8]
					xcusp[i] = 'XX'
					fl8 = 'Y'
					exit
			else		
				if xcombo[8] = cuspp[i]
						m_str = m_str + xcombo[8]
						fl8 = 'Y'
				endif
			endif
	endfor
	endif

	pattern = true
	for i = 1 to cusp_len
			if xcusp[i] <> 'XX'
				pattern = false
			endif
	endfor	
	
	if pattern = true
					select 3
					appe blank
					replace uid with "XXXXXXXXXXXXX"
					replace hid with "100001"
					replace planet with m_planet
					replace key with xkey
					replace combo with pstr1
					replace cuspstr with pstr2
					replace cuspid with cloc
					replace matchstr with m_str
	else
					select 4
					appe blank
					replace uid with "XXXXXXXXXXXXX"
					replace hid with "100001"
					replace planet with m_planet
					replace key with xkey
					replace combo with pstr1
					replace cuspstr with pstr2
					replace cuspid with cloc
					replace matchstr with m_str
	endif
	select 1
	return