function [mH, fH, mHdB] = freq_resp(b,a,N)

x = imp_resp(b,a,N);

fftX = fft(x);             %DFT z "x"
mH = abs(fftX);            %modul z DFT jako odp amplitudowa l.
fazaX = arg(fftX);         %faza z DFT
fH = unwrap_phase(fazaX);  %rozwinieta faza z DFT jako odp fazowa

for k = 1:N
  mHdB(k) = 20*log(mH(k)); %zamiana na db odp amplitudowa
endfor

% mH - odpowiedz amplitudowa liniowa
% mHdB - odpowiedz amplitudowa w dB
% fH - odpowiedz fazowa z faza rozwinieta

endfunction