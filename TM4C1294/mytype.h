/*
 * mytype.h
 *
 *  Created on: 2016��5��20��
 *      Author: Yi
 */


#ifndef MYTYPE_H_
#define MYTYPE_H_

typedef      char     int8; //in fact,16 bits.
typedef unsigned char   Uint8;//in fact,16 bits.
typedef unsigned char   uint8;//in fact,16 bits.

typedef  short      int16;
typedef unsigned short    Uint16;
typedef unsigned short    uint16;

typedef long            int32;
typedef unsigned long   Uint32;
typedef unsigned long   uint32;

typedef long long            int64;
typedef unsigned long long   Uint64;
typedef unsigned long long   uint64;

typedef volatile int8     vint8;
typedef volatile uint8    vuint8;

typedef volatile int16    vint16;
typedef volatile uint16   vuint16;

typedef volatile int32    vint32;
typedef volatile uint32   vuint32;

typedef volatile long long            vint64;
typedef volatile unsigned long long   vuint64;

typedef float           float32;
typedef long double     float64;

struct DATA_16BITS {     // bits description
	signed char	DATAL:8;
	signed char	DATAH:8;
};

union DATA_16B {
	int16 all;
	struct DATA_16BITS	bit;
};



#endif /* MYTYPE_H_ */
