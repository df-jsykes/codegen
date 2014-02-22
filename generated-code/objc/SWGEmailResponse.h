#import <Foundation/Foundation.h>
#import "NIKSwaggerObject.h"
#import "Integer.h"

@interface SWGEmailResponse : NIKSwaggerObject

@property(nonatomic) NSNumber* count;
- (id) count: (NSNumber*) count;

- (id) initWithValues: (NSDictionary*)dict;
- (NSDictionary*) asDictionary;


@end

