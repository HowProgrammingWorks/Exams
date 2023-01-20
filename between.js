const Word = 'different';
const Prefix = 'di';
const Suffix = 'en';
i = str.indexOf(p);
if (i == -1) return;
k = i + p.length;
str = str.substring(k);
i = str.indexOf(s);
if (i == -1) return;
str = str.substring(0, i);

