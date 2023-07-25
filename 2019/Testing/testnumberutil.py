"""
>>> import numberutil
>>> numberutil.aswords(800)
'eight hundred'
>>> numberutil.aswords(880)
'eight hundred and eighty'
>>> numberutil.aswords(611)
'six hundred and eleven'
>>> numberutil.aswords(0)
'zero'
>>> numberutil.aswords(39)
'thirty nine'
>>> numberutil.aswords(595)
'five hundred and ninety five'
>>> numberutil.aswords(690)
'six hundred and ninety'



"""
import doctest
doctest.testmod(verbose=True)