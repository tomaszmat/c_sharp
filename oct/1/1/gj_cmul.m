function [Cr,Ci]=gj_cmul(Ar,Ai,Br,Bi)
Cr=Ar*Br-Ai*Bi;
Ci=Ai*Br+Ar*Bi;
endfunction