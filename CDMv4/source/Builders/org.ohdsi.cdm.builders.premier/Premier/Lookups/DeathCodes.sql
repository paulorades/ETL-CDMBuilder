﻿SELECT DISTINCT SOURCE_CODE, 1 as concept_id, SOURCE_CODE_DESCRIPTION
FROM SOURCE_TO_CONCEPT_MAP
WHERE SOURCE_CODE in ('798.1',
'761.6',
'798',
'E913.1',
'798.2',
'E978',
'798.9',
'798.0')
