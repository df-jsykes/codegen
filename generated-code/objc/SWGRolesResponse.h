#import <Foundation/Foundation.h>
#import "NIKSwaggerObject.h"
#import "SWGRole.h"
#import "SWGMetadata.h"

@interface SWGRolesResponse : NIKSwaggerObject

@property(nonatomic) NSArray* record;
@property(nonatomic) SWGMetadata* meta;
- (id) record: (NSArray*) record
     meta: (SWGMetadata*) meta;

- (id) initWithValues: (NSDictionary*)dict;
- (NSDictionary*) asDictionary;


@end

