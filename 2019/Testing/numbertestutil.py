"""
>>> import numberutil
>>> numberutil.aswords(802)
'eight hundred and two'
>>> numberutil.aswords(125)
'one hundred and five'
>>> numberutil.aswords(666)
'six hundred and sixty six'
>>> numberutil.aswords(729)
'seven hundred and twenty nine'
>>> numberutil.aswords(435)
'four hundred and thirty five'
>>> numberutil.aswords(885)
'eight hundred and eighty five'
>>> numberutil.aswords(39)
'thirty nine'

"""
import doctest
doctest.testmod(verbose=True)