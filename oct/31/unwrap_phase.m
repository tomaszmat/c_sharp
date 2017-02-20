function [unwrapped_fi] = unwrap_phase(fi)	
	for n = 1 : length(fi)-1,	
		while(fi(n+1) - fi(n) > pi)	 
			fi(n+1) -= 2*pi;	
		endwhile

		while(fi(n+1) - fi(n) < -pi)	
			fi(n+1) += 2*pi;	
		endwhile
	endfor

	unwrapped_fi = fi;
endfunction	