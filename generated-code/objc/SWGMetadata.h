#import <Foundation/Foundation.h>
#import "NIKSwaggerObject.h"
#import "Integer.h"

@interface SWGMetadata : NIKSwaggerObject

@property(nonatomic) NSArray* schema;
@property(nonatomic) NSNumber* count;
- (id) schema: (NSArray*) schema
     count: (NSNumber*) count;

- (id) initWithValues: (NSDictionary*)dict;
- (NSDictionary*) asDictionary;


@end

