﻿{Source_to_Standard}
SELECT distinct SOURCE_CODE, TARGET_CONCEPT_ID
FROM CTE_VOCAB_MAP
WHERE lower(SOURCE_VOCABULARY_ID)='ndc'
AND lower(TARGET_VOCABULARY_ID)='rxnorm' 
AND lower(TARGET_DOMAIN_ID) = 'drug' 

